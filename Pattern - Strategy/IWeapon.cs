using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern___Strategy
{
    public interface IWeapon
    {
        public string Name { get; }
        public void UseWeapon();
    }

    public class Axe : IWeapon
    {
        public string Name => "Axe";
        public void UseWeapon()
        {
            Console.WriteLine("Slash");
        }
    }

    public class Knife : IWeapon
    {
        public string Name => "Knife";
        public void UseWeapon()
        {
            Console.WriteLine("Thrust");
        }
    }

    public class Bow : IWeapon
    {
        public string Name => "Bow";
        public void UseWeapon()
        {
            Console.WriteLine("Shot");
        }
    }

    public class Staff : IWeapon
    {
        public string Name => "Staff";
        public void UseWeapon()
        {
            Console.WriteLine("Magic whiff");
        }
    }
}
