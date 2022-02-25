namespace RPG_Game.src.Entities
{
    public class Topapa : Hero
    {
        public Topapa(string name, int level, string heroType, int hP, int mP) : base(name, level, heroType, hP, mP)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
            HP = hP;
            MP = mP;
        }

        public override string Attack()
        {
            return this.Name + " Lançou feitiço";
        }

        public string Attack(int bonus)
        {
            if (bonus > 5)
            {
                return this.Name + " Lançou SUPER feitiço com bonus de ataque de " + bonus;
            }
            else
            {
                return this.Name + " Lançou feitiço FRACO com bonus de ataque de " + bonus;
            }

        }
    }
}