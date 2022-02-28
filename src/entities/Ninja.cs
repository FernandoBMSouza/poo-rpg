namespace poo_rpg.src.entities
{
     public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType, int hp, int mp) : base(name, level, heroType, hp, mp)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.hp = hp;
            this.mp = mp;
        }

        public override string Attack()
        {
            return ($"{this.name} arremessou uma shuriken!");
        }
    }
}