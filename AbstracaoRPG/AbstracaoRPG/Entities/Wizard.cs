using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoRPG.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string herotype, int pointOfAttack)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = herotype;
            this.PointOfAttack = pointOfAttack;
        }

        public override string Attack()
        {
            if (this.PointOfAttack > 40)
            {
                return this.Name + " Lançou uma super magia com poder de Ataque Fulminante de : " + this.PointOfAttack + " pontos";
            }
            else
                return this.Name + " Lançou uma magia fraca com poder de Ataque de : " + this.PointOfAttack + " pontos";
        }

    }
}
