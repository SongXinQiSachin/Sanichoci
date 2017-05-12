using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Sanichoci.UI
{
    public interface IUIComponent
    {
        Transform Transform { get; set; }

        CanvasGroup CanvasGroup { get; set; }

        void Destroy();

        void Destroy(float delay);
    }
}
