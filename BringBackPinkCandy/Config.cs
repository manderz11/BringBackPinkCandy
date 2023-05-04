using System.ComponentModel;
using Exiled.API.Interfaces;

namespace BringBackPinkCandy
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("Chance to recieve pink candy in % (default 10%)")]
        public int Chance { get; set; } = 10;
        public bool Debug { get; set; } = false;
    }
}