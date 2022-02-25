namespace RPG_Game.src.Entities
{
    public class Arus : Hero
    {
        public Arus(string name, int level, string heroType, int hP, int mP) : base(name, level, heroType, hP, mP)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
            HP = hP;
            MP = mP;
        }

        public string Attack(int bonus)
        {
            if (bonus > 5)
            {
                return this.Name + " Lançou SUPER ataque de espada com bonus de ataque de " + bonus;
            }
            else
            {
                return this.Name + " Lançou ataque FRACO de espada com bonus de ataque de " + bonus;
            }

        }


    }
}