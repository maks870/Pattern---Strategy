using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern___Strategy
{
    public abstract class PlaybleClass
    {
        protected IWeapon weapon;
        protected ISkill skill;

        public void EquipWeapon(IWeapon newWeapon)
        {
            weapon = newWeapon;
            Console.WriteLine($"Equip {newWeapon.Name} weapon");
        }

        public void ReplaceSkill(ISkill newSkill)
        {
            skill = newSkill;
            Console.WriteLine($"Set {newSkill.Name} skill");
        }

        public void AttackAction()
        {
            weapon.UseWeapon();

        }

        public void SkillAction()
        {
            skill.UseSkill();
        }
    }
}
