namespace Pattern___Strategy
{
    class Warrior : PlaybleClass
    {
        public Warrior()
        {
            weapon = new Axe();
            skill = new DamageSkill();
        }
    }
}
