using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern___Strategy
{
    public class PlaybleClass
    {
        private IWeapon weapon;
        private ISkill skill;

        public void EquipWeapon(IWeapon newWeapon)
        {
            weapon = newWeapon;
        }
        public void ReplaceSkill(ISkill newSkill)
        {
            skill = newSkill;
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
    class Archer : PlaybleClass
    {
        private IWeapon weapon = new Bow();
        private ISkill skill = new DamageSkill();
    }
    class Rogue : PlaybleClass
    {
        private IWeapon weapon = new Knife();
        private ISkill skill = new MoveSkill();
    }
    class Mage : PlaybleClass
    {
        private IWeapon weapon = new Staff();
        private ISkill skill = new HealSkill();
    }
    class Warrior : PlaybleClass
    {
        private IWeapon weapon = new Axe();
        private ISkill skill = new DamageSkill();
    }
}
