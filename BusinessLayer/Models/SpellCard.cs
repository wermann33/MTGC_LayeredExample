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
    public enum ElementTypes
    {
        FIRE, WATER, EARTH, AIR, NORMAL
    }

    public class SpellCard(string name, int damage, ElementTypes elementType) : ICard
    {
        public string Name { get; } = name;
        public int Damage { get; set; } = damage;
        public ElementTypes ElementType { get; } = elementType;

        public void AdjustDamageBasedOnOpponent(ICard opponentCard)
        {
            throw new NotImplementedException();
        }

    }

}
