using Life;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm581
{
    public class Main : Plugin
    {
        public Main(IGameAPI api) : base(api) { }

        public override void OnPluginInit()
        {
            base.OnPluginInit();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Orm581] - Succes : Intiialise");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
