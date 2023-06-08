namespace Pattern___Strategy
{
    class Archer : PlaybleClass
    {
        public Archer()
        {
            weapon = new Bow();
            skill = new DamageSkill();
        }
    }
}
