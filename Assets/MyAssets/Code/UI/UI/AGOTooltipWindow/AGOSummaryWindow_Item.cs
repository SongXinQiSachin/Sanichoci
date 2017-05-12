using Sanichoci.Game;
using Sanichoci.Kits;
using Sanichoci.Logic.Arithmetic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using UnityEngine.UI;

namespace Sanichoci.UI
{
    public class AGOSummaryWindow_Item : AbstractAGOTooltipWindow
    {
        private Text tx_Name;

        protected override void OnCreate()
        {
            tx_Name = Transform.FindChild("Name").GetComponent<Text>();
        }

        private void Start()
        {
        }

        public override void UpdateData(AbstractAGameObject ago)
        {
            SetName(ago as AGameObject_AbstractItem);
        }

        public void SetName(AGameObject_AbstractItem ago_Item)
        {
            tx_Name.text = ago_Item.Name;
        }
    }
}
