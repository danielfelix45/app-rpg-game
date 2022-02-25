namespace RPG_Game.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        public Hero(string name, int level, string heroType, int hP, int mP)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
            HP = hP;
            MP = mP;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a espada";
        }

        public override string ToString()
        {
            return " Nome do Heroi: " +
            this.Name + "\n" +
            " Level: " +
            this.Level + "\n" +
            " Categoria do Heroi: " +
            this.HeroType + "\n" +
            " Hit Points: " +
            this.HP + "\n" +
            " Magic Points: " +
            this.MP;
        }
    }
}