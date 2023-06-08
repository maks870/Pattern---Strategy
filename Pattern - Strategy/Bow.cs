using System;

namespace Pattern___Strategy
{
    public class Bow : IWeapon
    {
        public string Name => "Bow";
        public void UseWeapon()
        {
            Console.WriteLine("Shot");
        }
    }
}
