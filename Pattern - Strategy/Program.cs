using System;

namespace Pattern___Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            PlaybleClass newClass = new Rogue();
            newClass.AttackAction();
            newClass.SkillAction();
            newClass.EquipWeapon(new Bow());
            newClass.AttackAction();
        }
    }
}
