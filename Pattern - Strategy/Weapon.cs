using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern___Strategy
{
    public interface Weapon
    {
        public void UseWeapon();
    }
    public class Axe : Weapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Slash");
        }
    }
    public class Knife : Weapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Thrust");
        }
    }
    public class Bow : Weapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shot");
        }
    }
    public class Staff : Weapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Magic whiff");
        }
    }
}
