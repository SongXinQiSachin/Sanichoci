using Sanichoci.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.UI
{
    public interface IAGOTooltipWindow : IUIComponent
    {
        void UpdateData(AbstractAGameObject obj);

        void FadeIn(float time);
        void FadeOut(float time);
    }
}
