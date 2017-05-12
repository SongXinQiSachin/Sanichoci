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
    public class AGOSummaryWindow_Unit : AbstractAGOTooltipWindow
    {
        private Text tx_Level;
        private Text tx_Name;

        private Text tx_HP;
        private Text tx_MP;
        private Text tx_SP;

        private Image img_HP;
        private Image img_MP;
        private Image img_SP;

        protected override void OnCreate()
        {
            tx_Level = FindChildObject("Level").GetComponent<Text>();
            tx_Name = FindChildObject("Name").GetComponent<Text>();
            tx_HP = FindChildObject("HP/HPText").GetComponent<Text>();
            tx_MP = FindChildObject("MP/MPText").GetComponent<Text>();
            tx_SP = FindChildObject("SP/SPText").GetComponent<Text>();

            img_HP = FindChildObject("HP/CurrentHP").GetComponent<Image>();
            img_MP = FindChildObject("MP/CurrentMP").GetComponent<Image>();
            img_SP = FindChildObject("SP/CurrentSP").GetComponent<Image>();
        }

        public override void UpdateData(AbstractAGameObject ago)
        {
            SetLevel(ago.Level);
            tx_Name.text = ago.Name;

            AGameObject_AbstractUnit ago_Unit = ago as AGameObject_AbstractUnit;
            if (ago_Unit != null)
            {
                tx_HP.text = ago_Unit.CurrentHP + "/" + ago_Unit.MaxHP;
                tx_MP.text = ago_Unit.CurrentMP + "/" + ago_Unit.MaxSP;
                tx_SP.text = ago_Unit.CurrentSP + "/" + ago_Unit.MaxMP;
            }
        }

        public void SetLevel(int level)
        {
            tx_Level.text = "Lv " + level;
        }
    }
}
