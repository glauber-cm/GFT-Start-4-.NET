namespace AbstracaoRPG.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string herotype, int pointOfAttack)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = herotype;
            this.PointOfAttack = pointOfAttack;
        }

    }
}
