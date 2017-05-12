using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game
{
    public interface ISPCaster : ICaster, ISP
    {
        bool HasEnoughSP(float cost);
        void CastSP();
    }
}
