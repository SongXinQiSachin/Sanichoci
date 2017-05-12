using cakeslice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.Component.GameObject
{
    [RequireComponent(typeof(Outline))]
    public class GameObjectEffectComponent : MonoBehaviour
    {
        private Outline _outline;

        private void Start()
        {
            _outline = GetComponent<Outline>();
        }

        public void SwitchOutlineState()
        {
            OutlineState = !OutlineState;
        }

        public bool OutlineState
        {
            get
            {
                return _outline.enabled;
            }
            set
            {
                _outline.enabled = value;
            }
        }

        public OutlineColorEnum OutlineColor
        {
            get
            {
                return (OutlineColorEnum)Enum.GetValues(typeof(OutlineColorEnum)).GetValue(_outline.color);
            }

            set
            {
                _outline.color = (int)value;
            }
        }

        public enum OutlineColorEnum : int
        {
            FIRST = 0,
            SECOND = 1,
            THIRD = 2
        }
    }
}
