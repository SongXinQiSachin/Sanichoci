using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using Sanichoci.Manager;
using cakeslice;

namespace Sanichoci.Component.GameObject.EventHandler
{
    [RequireComponent(typeof(GameObjectEffectComponent))]
    public class TerrainPointerEventHandler : PointerEventHandler
    {
        private OnRightClickOnTerrain onRightClick;

        private GameObjectEffectComponent _goe;
        private Transform _transform;

        private void Awake()
        {
            onRightClick = new OnRightClickOnTerrain();
            onRightClick.AddListener(PointerEventManager.Instance.OnRightClickOnTerrain);
        }

        private void Start()
        {
            _goe = GetComponent<GameObjectEffectComponent>();
            _transform = GetComponent<Transform>();

            _goe.OutlineColor = GameObjectEffectComponent.OutlineColorEnum.SECOND;
        }

        public override void OnPointerEnter(PointerEventData eventData)
        {
        }

        public override void OnPointerExit(PointerEventData eventData)
        {
        }

        public override void OnPointerDown(PointerEventData eventData)
        {
        }

        public override void OnPointerUp(PointerEventData eventData)
        {
        }

        public override void OnPointerClick(PointerEventData eventData)
        {
            switch (eventData.button)
            {
                case PointerEventData.InputButton.Left:
                    _goe.SwitchOutlineState();
                    break;
                case PointerEventData.InputButton.Right:
                    onRightClick.Invoke(this.gameObject, _transform.position);
                    break;
                case PointerEventData.InputButton.Middle:
                    break;
                default:
                    break;
            }
        }

        class OnRightClickOnTerrain : UnityEvent<UnityEngine.GameObject, Vector3>
        {
        }
    }
}
