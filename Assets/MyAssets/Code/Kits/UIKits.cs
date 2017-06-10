using Sanichoci.Manager;
using Sanichoci.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.Kits
{
    public class UIKits
    {
        public static Vector2 GetLocalPosFromScreenPos(Canvas canvas, Vector2 screenPos)
        {
            Vector2 result;

            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                canvas.transform as RectTransform,
                screenPos,
                canvas.worldCamera,
                out result);

            return result;
        }

        public static void ApplyLocalPosWorldPos(Transform transform, Canvas canvas, Vector2 pos)
        {
            transform.position = canvas.transform.TransformPoint(pos);
        }

        public static Vector2 GetUISize(Transform transform)
        {
            Vector2 result = new Vector2();

            RectTransform rt = transform.GetComponent<RectTransform>();

            if (rt != null)
            {
                Rect rect = rt.rect;
                result.x = rect.width;
                result.y = rect.height;
            }

            return result;
        }

        public static void MoveUIToCuursorPos(IUI ui)
        {
            Vector2 np = UIKits.GetLocalPosFromScreenPos(UIManager.Instance.GameSceneUICanvas, InputManager.Instance.GetCursorScreenPos());
            Vector2 size = UIKits.GetUISize(ui.Transform);
            np.x += size.x / 2;
            np.y += size.y / 2;
            UIKits.ApplyLocalPosWorldPos(ui.Transform, UIManager.Instance.GameSceneUICanvas, np);
        }
    }
}
