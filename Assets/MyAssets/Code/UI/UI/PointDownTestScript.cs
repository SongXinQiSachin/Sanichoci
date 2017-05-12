using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Sanichoci.UI.Event
{
    public class PointDownTestScript : MonoBehaviour, IPointerDownHandler
    {
        public void OnPointerDown(PointerEventData eventData)
        {
            Debug.Log("PointDown2222");
        }

        public void PointDownHandler()
        {
            Debug.Log("PointDown");
        }
        public void PointUpHandler()
        {
            Debug.Log("PointUp");
        }
    }
}
