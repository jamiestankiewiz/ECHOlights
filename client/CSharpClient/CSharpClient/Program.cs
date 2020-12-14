using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpClient
{
    class Program
    {

        public static bool exit;
        static void Main(string[] args) // Think of this as GBG
        {
            var init = new Initialization();
            init.Initialize(); // Initialize only once at the beginning before entering the engine

            while (!exit) // engine: where the main script will reside
            {
                // script 1: do something
                // script 2: do something
                // script 3: do something
                // script 4: our script
                var script4 = new LedStatusScript(init.MySocket);
                script4.Run();
            }
        }
    }
}
