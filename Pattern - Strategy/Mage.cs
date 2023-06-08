namespace Pattern___Strategy
{
    class Mage : PlaybleClass
    {
        public Mage()
        {
            weapon = new Staff();
            skill = new HealSkill();
        }
    }
}
