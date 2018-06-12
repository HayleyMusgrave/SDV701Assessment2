using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    interface IDragonControl
    {
        void PushData(clsAllDragons prDragon);
        void UpdateControl(clsAllDragons prDragon);
    }
}
