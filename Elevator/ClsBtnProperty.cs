using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class ClsBtnProperty
    {
        public int floorDestination;
        public string direction;
        public ClsEnums.ButtonName enumTag;

        public ClsBtnProperty(int floorDestination, string direction, ClsEnums.ButtonName enumTag)
        {
            this.floorDestination = floorDestination;
            this.direction = direction;
            this.enumTag = enumTag;
        }

    }
}
