using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern___Strategy
{
    public interface IWeapon
    {
        public void UseWeapon();
    }
    public class Axe : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Slash");
        }
    }
    public class Knife : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Thrust");
        }
    }
    public class Bow : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shot");
        }
    }
    public class Staff : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Magic whiff");
        }
    }
}
