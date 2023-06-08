using System;

namespace Pattern___Strategy
{
    public class Knife : IWeapon
    {
        public string Name => "Knife";
        public void UseWeapon()
        {
            Console.WriteLine("Thrust");
        }
    }
}
