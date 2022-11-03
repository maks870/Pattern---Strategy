using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern___Strategy
{
    public interface Skill
    {
        public void UseSkill();
    }
    public class DamageSkill : Skill
    {
        public void UseSkill()
        {
            Console.WriteLine("Take some damage");
        }
    }
    public class HealSkill : Skill
    {
        public void UseSkill()
        {
            Console.WriteLine("Heal someone's");
        }
    }
    public class MoveSkill : Skill
    {
        public void UseSkill()
        {
            Console.WriteLine("Move somewhere");
        }
    }
}
