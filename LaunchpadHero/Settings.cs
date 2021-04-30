using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadHero
{
    class Settings
    {
        public List<Key> Keys { get; set; }

        public Settings(List<Key> Keys)
        {
            this.Keys = Keys;
        }
    }
}
