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
    public class ItemPointerEventHandler : CreateTooltipPointerEventHandler, IGlobalSelectState
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

            MonitorCreateTooltip();
        }

        private void Update()
        {
            if (isPointerIn)
            {
                currentShowTooltipDelay += TimeKits.deltaTime();
            }
            else
            {
                currentShowTooltipDelay = 0.0f;
            }
        }

        public override void OnPointerEnter(PointerEventData eventData)
        {
            isPointerIn = true;
        }

        public override void OnPointerExit(PointerEventData eventData)
        {
            isPointerIn = false;
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

        bool isPointerIn = false;
        bool isShow = false;
        float showTooltopDelay = .618f;
        float currentShowTooltipDelay = 0.0f;
        protected override UnityEngine.GameObject TooltipPrefab()
        {
            return UIPrefabManager.Instance.AGOItemShortInformation;
        }

        protected override IAGOTooltipWindow TooltipComponent(UnityEngine.GameObject obj)
        {
            return obj.GetComponent<AGOSummaryWindow_Item>();
        }

        protected override bool CreateTooltipTag()
        {
            return !isShow && isPointerIn && currentShowTooltipDelay >= showTooltopDelay;
        }

        protected override bool DestroyTooltipTag()
        {
            return !isPointerIn;
        }

        protected override void OnCreateTooltip(IAGOTooltipWindow tooltip)
        {
            tooltip.FadeIn(0.618f);
            tooltip.UpdateData((AGameObject_AbstractItem)_ago._ago);
            isShow = true;
        }

        protected override void OnTooltipShow(IAGOTooltipWindow tooltip)
        {
            UIKits.MoveUIToCuursorPos(tooltip);
        }

        protected override float OnDestroyTooltip(IAGOTooltipWindow tooltip)
        {
            tooltip.FadeOut(0.25f);
            tooltip.Destroy(0.25f);

            isShow = false;

            return 0.25f;
        }
    }
}
