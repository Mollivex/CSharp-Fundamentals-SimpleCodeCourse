using MyProject_115;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_115
{
    class Player
    {
        public void Fire(IWeapon iweapon)
        {
            iweapon.Fire();
        }
        public void CheckInfo(IHasInfo hasInfo)
        {
            hasInfo.ShowInfo();
        }
    }
}
