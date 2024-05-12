using MyProject_115;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_115
{
    abstract class Weapon : IHasInfo, IWeapon
    {
        public abstract int Damage { get; }
        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Damage: {Damage}");
        }
    }
}
