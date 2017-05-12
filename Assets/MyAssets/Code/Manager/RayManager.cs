using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.Manager
{
    public partial class RayManager : IManager
    {
        public delegate void OnHit(Transform obj, RaycastHit hit);

        public void RegisterOnHitDelegate(OnHit onHit)
        {
            onHitDegelate += onHit;
        }

        public void UnregisterOnHitDelegate(OnHit onHit)
        {
            onHitDegelate -= onHit;
        }

        public bool Raycast(Camera camera, Vector3 position, out RaycastHit hit)
        {
            Ray ray = camera.ScreenPointToRay(position);
            RaycastHit outHit;

            bool isHit = Physics.Raycast(ray, out outHit);

            hit = outHit;

            return isHit;
        }
    }
}
