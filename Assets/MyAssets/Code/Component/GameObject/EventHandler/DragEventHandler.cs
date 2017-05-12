using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Sanichoci.Component.GameObject.EventHandler
{
    public class DragEventHandler : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
    {
        private Rigidbody _rigidbody;
        private Transform _transform;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _transform = transform;
        }

        public void OnDrag(PointerEventData eventData)
        {
            Vector3 pos = eventData.pointerCurrentRaycast.worldPosition;
            pos.y = _transform.position.y;
            transform.position = pos;
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
            {
                _rigidbody.useGravity = false;

                Vector3 pos = _transform.position;
                pos.y += 1;
                _transform.position = pos;
            }
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
            {
                _rigidbody.useGravity = true;

                Vector3 pos = _transform.position;
                pos.y -= 1;
                _transform.position = pos;
            }
        }
    }
}
