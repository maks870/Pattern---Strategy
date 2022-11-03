using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern___Strategy
{
    public class PlaybleClass
    {
        private Weapon weapon;
        private Skill skill;

        public void EquipWeapon(Weapon newWeapon)
        {
            weapon = newWeapon;
        }
        public void ReplaceSkill(Skill newSkill)
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
        private Weapon weapon = new Bow();
        private Skill skill = new DamageSkill();
    }
    class Rogue : PlaybleClass
    {
        private Weapon weapon = new Knife();
        private Skill skill = new MoveSkill();
    }
    class Mage : PlaybleClass
    {
        private Weapon weapon = new Staff();
        private Skill skill = new HealSkill();
    }
    class Warrior : PlaybleClass
    {
        private Weapon weapon = new Axe();
        private Skill skill = new DamageSkill();
    }
}
