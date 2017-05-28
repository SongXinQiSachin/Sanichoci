using Sanichoci.Factory;
using Sanichoci.Game;
using Sanichoci.Kits;
using Sanichoci.Manager;
using Sanichoci.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Sanichoci.Component.GameObject.EventHandler
{
    [RequireComponent(typeof(GameObjectEffectComponent))]
    public class ItemPointerEventHandler : PointerEventHandler, IGlobalSelectState
    {
        private AGameObjectComponent _ago;

        private GameObjectEffectComponent _goe;

        private void Awake()
        {
        }

        private void Start()
        {
            _ago = GetComponent<AGameObjectComponent>();
            _goe = GetComponent<GameObjectEffectComponent>();
            _goe.OutlineColor = GameObjectEffectComponent.OutlineColorEnum.FIRST;

            _goe.OutlineState = false;
        }

        public override void OnPointerClick(PointerEventData eventData)
        {
            switch (eventData.button)
            {
                case PointerEventData.InputButton.Left:
                    break;
                case PointerEventData.InputButton.Right:
                    break;
                case PointerEventData.InputButton.Middle:
                    break;
                default:
                    break;
            }
        }

        public void OnGlobalSelected()
        {
            _goe.OutlineState = true;
        }

        public void OnGlobalUnSelected()
        {
            _goe.OutlineState = false;
        }
    }
}
