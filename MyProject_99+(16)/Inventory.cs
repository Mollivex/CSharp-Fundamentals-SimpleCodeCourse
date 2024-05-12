using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_115
{
    class Gun : Weapon
    {
        public override int Damage { get { return 5; } }

        public override void Fire()
        {
            Console.WriteLine("Boom-boom!");
        }
    }
    class LaserGun : Weapon
    {
        public override int Damage => 9;

        public override void Fire()
        {
            Console.WriteLine("Bom-bom!");
        }
    }
    class Bow : Weapon
    {
        public override int Damage => 3;

        public override void Fire()
        {
            Console.WriteLine("Bam-bam!");
        }
    }
}
