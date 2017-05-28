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
    public class UnitPointerEventHandler : PointerEventHandler, IGlobalSelectState
    {
        private AGameObjectComponent _ago;

        private OnUnitSingleSelectedEvent onUnitSingleSelectedEvent;

        private GameObjectEffectComponent _goe;

        private void Awake()
        {
            onUnitSingleSelectedEvent = new OnUnitSingleSelectedEvent();
            onUnitSingleSelectedEvent.AddListener(GlobalUnitSelectedManager.Instance.OnUnitSelected);
        }

        private void Start()
        {
            _ago = GetComponent<AGameObjectComponent>();
            _goe = GetComponent<GameObjectEffectComponent>();
            _goe.OutlineColor = GameObjectEffectComponent.OutlineColorEnum.FIRST;
        }
        public override void OnPointerClick(PointerEventData eventData)
        {
            switch (eventData.button)
            {
                case PointerEventData.InputButton.Left:
                    onUnitSingleSelectedEvent.Invoke(this.gameObject);
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

    public class OnUnitSingleSelectedEvent : UnityEvent<UnityEngine.GameObject>
    {
    }
}
