namespace AbstracaoRPG.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int PointOfAttack { get; set; }

        protected Hero(string name, int level, string heroType, int pointOfAttack)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.PointOfAttack = pointOfAttack;
        }

        public Hero()
        {

        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.PointOfAttack;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua espada com poder de ataque de: " + this.PointOfAttack + " pontos";
        }
    }
}
