using System;

namespace Pattern___Strategy
{
    public class HealSkill : ISkill
    {
        public string Name => "HealSkill";
        public void UseSkill()
        {
            Console.WriteLine("Heal someone's");
        }
    }
}
