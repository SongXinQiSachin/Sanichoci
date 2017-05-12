using Sanichoci.Kits;
using Sanichoci.Logic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using UnityEngine.Events;

namespace Sanichoci.Manager
{
    public partial class InputManager : IManager
    {
        public static readonly float DOUBLE_CLICK_DELAY_TIME = 0.382f;

        public bool IsFirstButtonDown()
        {
            return Input.GetButtonDown("Fire1");
        }
        public bool IsSecondButtonDown()
        {
            return Input.GetButtonDown("Fire2");
        }
        public bool IsThirdButtonDown()
        {
            return Input.GetButtonDown("Fire3");
        }

        public bool IsKeyHold(KeyCode keyCode)
        {
            return Input.GetKey(keyCode);
        }

        public bool IsKeyDown(KeyCode keyCode)
        {
            return Input.GetKeyDown(keyCode);
        }

        public Vector3 GetInputButtonPosition()
        {
            return Input.mousePosition;
        }

        public Vector2 GetCursorScreenPos()
        {
            return Input.mousePosition;
        }

        public Vector3 GetWorldPositionFcomCursorWithRaycast(Camera source)
        {
            Vector3 result = new Vector3();
            Ray ray = source.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            bool isHit = Physics.Raycast(ray, out hit);

            if (isHit)
            {
                result = hit.point;
            }

            return result;
        }

        public Vector3 GetWorldPositionFromCursor(Camera source, float distance)
        {
            Ray ray = source.ScreenPointToRay(Input.mousePosition);

            return ray.GetPoint(distance);
        }

        public void WaitForDoubleClick(KeyCode keyCode, UnityAction action)
        {
            if (Input.GetKeyDown(keyCode))
            {
                CoroutineKits.StartCoroutine(CheckDoubleClick(keyCode, action));
            }
        }

        IEnumerator CheckDoubleClick(KeyCode keyCode, UnityAction action)
        {
            yield return new WaitForEndOfFrame();
            float passedTime = 0;
            bool ret = false;

            while (true)
            {
                if (passedTime > DOUBLE_CLICK_DELAY_TIME || ret)
                {
                    break;
                }

                if (Input.GetKeyDown(keyCode))
                {
                    ret = true;
                }

                passedTime += TimeKits.deltaTime();
                yield return new WaitForFixedUpdate();
            }

            if (ret)
            {
                action.Invoke();
            }

            yield return 0;
        }
    }
}
