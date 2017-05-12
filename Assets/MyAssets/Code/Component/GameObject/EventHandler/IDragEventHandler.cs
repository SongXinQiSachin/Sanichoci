using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using UnityEngine.EventSystems;

namespace Sanichoci.Component.GameObject.EventHandler
{
    public interface IDragEventHandler : IEventHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
    {
    }
}
