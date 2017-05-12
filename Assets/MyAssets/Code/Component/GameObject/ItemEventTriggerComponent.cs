using Sanichoci.Component.GameObject.EventHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Sanichoci.Component.GameObject
{
    public class ItemEventTriggerComponent : GameObjectEventTriggerComponent
    {
        private void Start()
        {
            gameObject.AddComponent<DragEventHandler>();
            gameObject.AddComponent<ItemPointerEventHandler>();
        }
    }
}
