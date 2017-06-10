using Sanichoci.Component.GameObject.EventHandler;
using Sanichoci.Component.OGO.AGO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using UnityEngine.Events;

namespace Sanichoci.Manager
{
    public partial class GlobalUnitSelectedManager : IManager
    {
        private GameObject currentSelectedUnit = null;
        private UnityAction<GameObject> onUnitSelected = null;

        private GlobalUnitSelectedManager()
        {
            onUnitSelected = new UnityAction<GameObject>(
            (obj) =>
            {
                IGlobalSelectState upeh = null;
                if (null != currentSelectedUnit)
                {
                    upeh = currentSelectedUnit.GetComponent<UnitPointerEventHandler>();
                    upeh.OnGlobalUnSelected();
                }

                currentSelectedUnit = obj;
                upeh = currentSelectedUnit.GetComponent<UnitPointerEventHandler>();
                upeh.OnGlobalSelected();
            });
        }

        public UnityAction<GameObject> OnUnitSelected
        {
            get
            {
                return onUnitSelected;
            }
        }

        public GameObject CurrentSelectedUnit
        {
            get
            {
                return currentSelectedUnit;
            }
        }
    }
}
