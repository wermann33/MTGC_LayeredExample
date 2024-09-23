using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using MTGC.BusinessLayer.Interfaces;

namespace MTGC.BusinessLayer.Models
{
    public class MonsterCard(string name, int damage) : ICard
    {
        public string Name { get; } = name;
        public int Damage { get; set; } = damage;

        public void AdjustDamageBasedOnOpponent(ICard opponentCard)
        {
            throw new NotImplementedException();
        }
    }

}
