using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game
{
    public interface IHPCaster : ICaster, IHP
    {
        bool HasEnoughHP(float cost);
        void CastHP();
    }
}
