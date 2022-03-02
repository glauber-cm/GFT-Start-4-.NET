
namespace AbstracaoRPG.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string herotype, int pointOfAttack)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = herotype;
            this.PointOfAttack = pointOfAttack;
        }

        public override string Attack()
        {
            if (this.PointOfAttack > 15)
            {
                return this.Name + " Lançou um ataque de espada e adagas com poder de Ataque Fulminante de : " + this.PointOfAttack + " pontos";
            }
            else 
                return this.Name + " Lançou um ataque inoperante de espada e adagas com poder de Ataque de : " + this.PointOfAttack + " pontos";
        }
    }
}
