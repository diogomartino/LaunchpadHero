using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using LaunchpadNET;
using WindowsInput;
using WindowsInput.Native;
using System.Threading;
using System.IO;
using Newtonsoft.Json;

namespace LaunchpadHero
{
    public partial class MainForm : MetroForm
    {
        private InputSimulator inputSimulator = new InputSimulator();
        private Settings settings;
        public Interface lint;

        bool isListeningForKeys = false;
        string selectedTile = "";

        public MainForm()
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager1;

            LoadSettings();
            LoadLaunchpads();
        }

        private void LoadSettings()
        {
            if(!File.Exists("data.json"))
            {
                List<Key> keys = new List<Key>();
                keys.Add(new Key(4, 0, "CIRCLE_GREEN", "VK_A", 21));
                keys.Add(new Key(4, 1, "CIRCLE_RED", "VK_S", 6));
                keys.Add(new Key(4, 2, "CIRCLE_YELLOW", "VK_D", 13));
                keys.Add(new Key(4, 3, "CIRCLE_BLUE", "VK_F", 47));
                keys.Add(new Key(4, 4, "CIRCLE_ORANGE", "VK_G", 108));

                keys.Add(new Key(7, 4, "STAR", "SPACE", 98));
                keys.Add(new Key(0, 0, "EXIT", "RETURN", 3));
                keys.Add(new Key(2, 6, "CHORD1", "UP", 96));
                keys.Add(new Key(3, 6, "CHORD2", "DOWN", 96));

                File.Create("data.json").Close();
                File.WriteAllText("data.json", JsonConvert.SerializeObject(new Settings(keys)));
            }

            string loadedData = File.ReadAllText("data.json");
            settings = JsonConvert.DeserializeObject<Settings>(loadedData);
        }

        private void SaveSettings()
        {
            File.WriteAllText("data.json", JsonConvert.SerializeObject(settings));
        }

        private void LoadLaunchpads()
        {
            lint = new Interface();

            Interface.LaunchpadDevice[] devices = lint.getConnectedLaunchpads();

            devicesComboBox.Items.Clear();

            foreach (Interface.LaunchpadDevice i in devices)
            {
                devicesComboBox.Items.Add(i._midiName);
            }

            if(devicesComboBox.Items.Count > 0)
            {
                devicesComboBox.SelectedIndex = 0;
            }
        }

        private void ForceClearAllLeds()
        {
            for(int x = 0;x < 8; x++)
            {
                for(int y = 0; y < 8; y++)
                {
                    lint.setLED(x, y, 0);
                }
            }

            lint.setTopLED(TopLEDs.Up, 0);
            lint.setTopLED(TopLEDs.Down, 0);
            lint.setTopLED(TopLEDs.Session, 0);
        }

        private void ForceLightAllLeds()
        {
            int color = new Random().Next(1, 128);

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    lint.setLED(x, y, color);
                }
            }

            lint.setTopLED(TopLEDs.Up, color);
            lint.setTopLED(TopLEDs.Down, color);
            lint.setTopLED(TopLEDs.Session, color);
        }

        private void ConnectLaunchpad(int index)
        {
            if(lint.Connected)
            {
                lint.disconnect(lint.getConnectedLaunchpads()[index]);
            }
            
            lint.connect(lint.getConnectedLaunchpads()[index]);
            LoadLeds();

            lint.OnLaunchpadKeyDown += LaunchpadKeyDownHandler;
            lint.OnLaunchpadKeyUp += LaunchpadKeyUpHandler;
            lint.OnLaunchpadCCKeyDown += LaunchpadCCDownHandler;
        }

        private void LoadLeds()
        {
            ForceClearAllLeds();

            foreach(Key k in settings.Keys)
            {
                lint.setLED(k.X, k.Y, k.Velocity);
            }

            lint.setTopLED(TopLEDs.Up, 3);
            lint.setTopLED(TopLEDs.Down, 3);
            lint.setTopLED(TopLEDs.Session, 3);
        }

        private void LaunchpadCCDownHandler(object source, Interface.LaunchpadCCKeyEventArgs e)
        {
            int val = e.GetVal();

            Console.WriteLine("CC {0}", val);

            VirtualKeyCode key = GetSelectedTopKey(val);

            Thread t = new Thread(() => HandleCCKeyPressThread(key));
            t.Start();

        }

        private void LaunchpadKeyUpHandler(object source, Interface.LaunchpadKeyEventArgs e)
        {
            int x = e.GetX();
            int y = e.GetY();

            Console.WriteLine("Up {0} {1}", x, y);

            if(isListeningForKeys)
            {
                HandleNewKey(x, y);
            }
            else
            {
                VirtualKeyCode key = GetSelectedKey(x, y);

                Thread t = new Thread(() => HandleKeyUpPressThread(key));
                t.Start();
            }
        }

        private VirtualKeyCode GetSelectedTopKey(int val)
        {
            VirtualKeyCode key = VirtualKeyCode.ACCEPT;

            if (val == 104)
            {
                key = VirtualKeyCode.UP;

            }
            else if (val == 105)
            {
                key = VirtualKeyCode.DOWN;
            }
            else if(val == 108)
            {
                key = VirtualKeyCode.RETURN;
            }

            return key;
        }

        private VirtualKeyCode GetSelectedKey(int x, int y)
        {
            VirtualKeyCode key = VirtualKeyCode.ACCEPT;

            foreach(Key k in settings.Keys)
            {
                if(k.X == x && k.Y == y)
                {
                   key = (VirtualKeyCode) Enum.Parse(typeof(VirtualKeyCode), k.KeyName);
                }
            }

            return key;
        }
        private void HandleCCKeyPressThread(VirtualKeyCode key)
        {
            inputSimulator.Keyboard.KeyPress(key);

        }

        private void HandleKeyUpPressThread(VirtualKeyCode key)
        {
            inputSimulator.Keyboard.KeyUp(key);
        }

        private void HandleKeyDownPressThread(VirtualKeyCode key)
        {
            inputSimulator.Keyboard.KeyDown(key);
        }


        private void LaunchpadKeyDownHandler(object source, Interface.LaunchpadKeyEventArgs e)
        {
            int x = e.GetX();
            int y = e.GetY();

            Console.WriteLine("Down {0} {1}", x, y);

            VirtualKeyCode key = GetSelectedKey(x, y);

            Thread t = new Thread(() => HandleKeyDownPressThread(key));
            t.Start();
        }

        private void devicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectLaunchpad(devicesComboBox.SelectedIndex);
        }

        private void TestLaunchpad()
        {
            ForceClearAllLeds();

            for(int i = 0; i < 30; i++)
            {
                ForceLightAllLeds();
                Thread.Sleep(100);
                ForceClearAllLeds();
            }

            LoadLeds();
        }

        private void SetKeyProperties(string name, int x, int y)
        {
            foreach(Key k in settings.Keys)
            {
                if(k.Name == name)
                {
                    k.X = x;
                    k.Y = y;
                    break;
                }
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            new Thread(TestLaunchpad).Start();
        }

        private void HandleNewKey(int x, int y)
        {
            SetKeyProperties(selectedTile, x, y);
            StopListeningForKeys();
            SaveSettings();
            LoadLeds();

            Console.WriteLine("Handled new key");
        }

        private void StartListeningForKeys(string name)
        {
            isListeningForKeys = true;
            selectedTile = name;
            labelWarning.Visible = true;
        }

        private void StopListeningForKeys()
        {
            isListeningForKeys = false;
            selectedTile = "";

            labelWarning.Invoke((MethodInvoker)delegate
            {
                labelWarning.Visible = false;
            });
        }

        private void metroTileA_MouseClick(object sender, MouseEventArgs e)
        {
            StartListeningForKeys("CIRCLE_GREEN");
        }

        private void metroTileS_MouseClick(object sender, MouseEventArgs e)
        {
            StartListeningForKeys("CIRCLE_RED");
        }

        private void metroTileD_MouseClick(object sender, MouseEventArgs e)
        {
            StartListeningForKeys("CIRCLE_YELLOW");
        }

        private void metroTileF_MouseClick(object sender, MouseEventArgs e)
        {
            StartListeningForKeys("CIRCLE_BLUE");
        }

        private void metroTileG_MouseClick(object sender, MouseEventArgs e)
        {
            StartListeningForKeys("CIRCLE_ORANGE");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ForceClearAllLeds();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go to Clone Hero controls and set the Green, Red, Yellow, Blue and Orange notes to the keys A, S, D, F and G, respectively.\n" +
                "Assign the Star Bonus to the Space key.\n" +
                "Assign the Strum Up and Strum Down to Arrow Up and Arrow Down, respectively.\n" +
                "In Launchpad Hero, you click on the colored buttons and then on a launchpad key to change that note/action to that key.", "Tutorial");
        }

        private void metroTileUp1_MouseClick(object sender, MouseEventArgs e)
        {
            StartListeningForKeys("CHORD1");
        }

        private void metroTileUp2_MouseClick(object sender, MouseEventArgs e)
        {
            StartListeningForKeys("CHORD2");
        }

        private void metroTileStar_MouseClick(object sender, MouseEventArgs e)
        {
            StartListeningForKeys("STAR");
        }

        private void metroTileESC_MouseClick(object sender, MouseEventArgs e)
        {
            StartListeningForKeys("EXIT");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(-1);
        }

        private void refreshButtton_Click(object sender, EventArgs e)
        {
            LoadLaunchpads();
        }
    }
}
