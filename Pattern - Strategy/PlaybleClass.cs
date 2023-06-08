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

    class Archer : PlaybleClass
    {
        public Archer()
        {
            weapon = new Bow();
            skill = new DamageSkill();
        }
    }

    class Rogue : PlaybleClass
    {
        public Rogue()
        {
            weapon = new Knife();
            skill = new MoveSkill();
        }
    }

    class Mage : PlaybleClass
    {
        public Mage()
        {
            weapon = new Staff();
            skill = new HealSkill();
        }
    }

    class Warrior : PlaybleClass
    {
        public Warrior()
        {
            weapon = new Axe();
            skill = new DamageSkill();
        }
    }
}
