using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MTGC.BusinessLayer.Interfaces
{
    public interface ICard
    {
        string Name { get; }
        int Damage { get; set; }

        public void AdjustDamageBasedOnOpponent(ICard opponentCard);
    }

}
