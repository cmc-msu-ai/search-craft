using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralPackage.Controller;
using GeneralPackage.GameData;
using GeneralPackage.Structures;

namespace WindowsFormsApplication1
{
    class SimpleWalker : AgentBaseClass
    {
        private IWalker com;
        bool seted = false;
        string mode;

        public SimpleWalker()
        {

        }

        public SimpleWalker(string mode)
        {
            this.mode = mode;
        }



        public override void setController(ControllerSet com_) {
            com = com_.iWalker;
            seted = true;
        }

        public override void makeTurn()
        {
            if (!seted){
                return;
            }

            switch (mode)
            {
                case "move right":
                    com.makeStep(new Coord(1.0, 0), 0.9);
                    break;
                case "random movement":
                    Coord c = Coord.rand();
                    c.x -= 0.5;
                    c.y -= 0.5;
                    com.makeStep(c, 1);
                    break;
            }
        }
    }
}
