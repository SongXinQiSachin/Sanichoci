using Sanichoci.Game;
using Sanichoci.OGO.AGO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.UI
{
    public interface IAGOTooltipWindow : IUI
    {
        void UpdateData(AbstractAGO obj);

        void FadeIn(float time);
        void FadeOut(float time);
    }
}
