using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern___Strategy
{
    public interface ISkill
    {
        public void UseSkill();
    }
    public class DamageSkill : ISkill
    {
        public void UseSkill()
        {
            Console.WriteLine("Take some damage");
        }
    }
    public class HealSkill : ISkill
    {
        public void UseSkill()
        {
            Console.WriteLine("Heal someone's");
        }
    }
    public class MoveSkill : ISkill
    {
        public void UseSkill()
        {
            Console.WriteLine("Move somewhere");
        }
    }
}
