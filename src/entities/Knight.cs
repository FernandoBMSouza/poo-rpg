namespace poo_rpg.src.entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType, int hp, int mp) : base(name, level, heroType, hp, mp)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.hp = hp;
            this.mp = mp;
        }
    }
}