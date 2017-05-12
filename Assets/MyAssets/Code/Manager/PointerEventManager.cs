using Sanichoci.Component.GameObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Sanichoci.Manager
{
    public partial class PointerEventManager : IManager
    {
        private UnityAction<GameObject, Vector3> onRightClickOnTerrain =
            new UnityAction<GameObject, Vector3>(
                (obj, pos) =>
                {
                    GameObject csu = GlobalUnitSelectedManager.Instance.CurrentSelectedUnit;
                    if (csu != null)
                    {
                        SimpleMoveComponent sm = csu.GetComponent<SimpleMoveComponent>();

                        sm.MoveTo(pos);
                    }
                }
                );

        public UnityAction<GameObject, Vector3> OnRightClickOnTerrain
        {
            get
            {
                return onRightClickOnTerrain;
            }
        }
    }
}
