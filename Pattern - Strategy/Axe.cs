using System;

namespace Pattern___Strategy
{
    public class Axe : IWeapon
    {
        public string Name => "Axe";
        public void UseWeapon()
        {
            Console.WriteLine("Slash");
        }
    }
}
