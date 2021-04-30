using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadHero
{
    class Key
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }
        public string KeyName { get; set; }
        public int Velocity { get; set; }

        public Key(int X, int Y, string Name, string KeyName, int Velocity)
        {
            this.X = X;
            this.Y = Y;
            this.Name = Name;
            this.KeyName = KeyName;
            this.Velocity = Velocity;
        }
    }
}
