using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.UI
{
    [RequireComponent(typeof(CanvasGroup))]
    public abstract class AbstractUIComponent : MonoBehaviour, IUI
    {
        public Transform Transform { get; set; }

        public CanvasGroup CanvasGroup { get; set; }

        private void Awake()
        {
            Transform = transform;
            CanvasGroup = GetComponent<CanvasGroup>();

            OnCreate();
        }

        protected Transform FindChildObject(string name)
        {
            return Transform.FindChild(name);
        }

        public void Destroy()
        {
            Destroy(this.gameObject);
        }

        public void Destroy(float delay)
        {
            Destroy(this.gameObject, delay);
        }

        protected abstract void OnCreate();

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
