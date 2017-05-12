using Sanichoci.Factory;
using Sanichoci.Kits;
using Sanichoci.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Component.GameObject.EventHandler
{
    public abstract class CreateTooltipPointerEventHandler : PointerEventHandler
    {
        protected abstract UnityEngine.GameObject TooltipPrefab();

        protected abstract IAGOTooltipWindow TooltipComponent(UnityEngine.GameObject obj);

        protected abstract bool CreateTooltipTag();
        protected abstract bool DestroyTooltipTag();

        protected abstract void OnCreateTooltip(IAGOTooltipWindow tooltip);
        protected abstract float OnDestroyTooltip(IAGOTooltipWindow tooltip);
        protected abstract void OnTooltipShow(IAGOTooltipWindow tooltip);


        private bool isMonitor;
        protected void MonitorCreateTooltip()
        {
            if (isMonitor)
            {
                return;
            }

            isMonitor = true;
            StartCoroutine(CreateTooltipListener());
        }

        protected void StopMonitor()
        {
            isMonitor = false;
        }


        IEnumerator CreateTooltipListener()
        {
            UnityEngine.GameObject tooltipGO = null;
            IAGOTooltipWindow tooltip = null;
            bool isDestroy = false;
            while (isMonitor)
            {
                if (CreateTooltipTag())
                {
                    tooltipGO = UIFactory.CreateAGOShortInformationPopup(TooltipPrefab());
                    tooltip = TooltipComponent(tooltipGO);

                    OnCreateTooltip(tooltip);
                    isDestroy = false;
                }
                if (null != tooltip)
                {
                    OnTooltipShow(tooltip);
                }
                if(DestroyTooltipTag())
                {
                    if (null != tooltipGO)
                    {
                        float delay = OnDestroyTooltip(tooltip);

                        tooltipGO = null;
                        tooltip = null;
                    }
                }

                yield return null;
            }

            yield return null;
        }

    }
}
