namespace poo_rpg.src.entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType, int hp, int mp) : base(name, level, heroType, hp, mp)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.hp = hp;
            this.mp = mp;
        }

        public override string Attack()
        {
            if(heroType == "White Wizard")
                return ($"{this.name} lancou magia de luz!");
            else if(heroType == "Black Wizard")
                return ($"{this.name} lancou magia das trevas!");
            else
                return ($"{this.name} lancou uma magia!");
        }

        public string Attack(int bonus){
            if(bonus > 6)
                return($"{this.name} lancou magia forte com bonus de {bonus}!");
            else
                return($"{this.name} lancou magia fraca com bonus de {bonus}!");
        }
    }
}