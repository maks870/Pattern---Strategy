using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern___Strategy
{
    public interface ISkill
    {
        public string Name { get; }
        public void UseSkill();
    }

    public class DamageSkill : ISkill
    {
        public string Name => "DamageSkill";
        public void UseSkill()
        {
            Console.WriteLine("Take some damage");
        }
    }

    public class HealSkill : ISkill
    {
        public string Name => "HealSkill";
        public void UseSkill()
        {
            Console.WriteLine("Heal someone's");
        }
    }

    public class MoveSkill : ISkill
    {
        public string Name => "MoveSkill";
        public void UseSkill()
        {
            Console.WriteLine("Move somewhere");
        }
    }
}
