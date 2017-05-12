using Sanichoci.Kits;
using Sanichoci.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Sanichoci.Factory
{
    public class UIFactory
    {

        public static GameObject CreateAGOShortInformationPopup(GameObject shortInformationPopupPrefab)
        {
            GameObject popup = PoolManager.Instance.Spawn(shortInformationPopupPrefab);

            RectTransform transform = popup.GetComponent<RectTransform>();

            popup.transform.SetParent(UIManager.Instance.GameSceneUITransform, false);

            return popup;
        }

        public static GameObject CreateAGOShortInformationPopup(GameObject shortInformationPopupPrefab, Vector2 pos, bool avoidCursor)
        {
            GameObject popup = PoolManager.Instance.Spawn(shortInformationPopupPrefab);

            RectTransform transform = popup.GetComponent<RectTransform>();

            popup.transform.SetParent(UIManager.Instance.GameSceneUITransform, false);

            pos = UIKits.GetLocalPosFromScreenPos(UIManager.Instance.GameSceneUICanvas, InputManager.Instance.GetCursorScreenPos());

            pos.x += transform.rect.width / 2;
            pos.y += transform.rect.height / 2;

            UIKits.ApplyLocalPosWorldPos(transform, UIManager.Instance.GameSceneUICanvas, pos);

            return popup;
        }
    }
}
