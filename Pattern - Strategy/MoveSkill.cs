using System;

namespace Pattern___Strategy
{
    public class MoveSkill : ISkill
    {
        public string Name => "MoveSkill";
        public void UseSkill()
        {
            Console.WriteLine("Move somewhere");
        }
    }
}
