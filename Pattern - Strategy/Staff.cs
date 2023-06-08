using System;

namespace Pattern___Strategy
{
    public class Staff : IWeapon
    {
        public string Name => "Staff";
        public void UseWeapon()
        {
            Console.WriteLine("Magic whiff");
        }
    }
}
