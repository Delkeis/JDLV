using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeJeuDeLaVie.Classes
{
    class Controller
    {
        public string startEngine()
        {
            Engine myEngine = new Engine();
            return (myEngine.engineTest());
        }
    }
}
