using System;

namespace Pattern___Strategy
{
    public class DamageSkill : ISkill
    {
        public string Name => "DamageSkill";
        public void UseSkill()
        {
            Console.WriteLine("Take some damage");
        }
    }
}
