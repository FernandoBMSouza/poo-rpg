namespace poo_rpg.src.entities
{
    public abstract class Hero
    {
        #region variables
        protected string name, heroType;
        protected int level, hp, mp;
        #endregion
        public Hero(string name, int level, string heroType, int hp, int mp)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.hp = hp;
            this.mp = mp;
        }

        public override string ToString()
        {
            return ($@"
            Nome: {this.name}
            Level: {this.level}
            HeroType: {this.heroType}
            HP: {this.hp}
            MP: {this.mp}
            ");
        }

        public virtual string Attack()
        {
            return ($"{this.name} atacou com sua espada!");
        }
    }
}