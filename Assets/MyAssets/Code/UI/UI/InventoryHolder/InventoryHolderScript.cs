using Sanichoci.Kits;
using Sanichoci.Logic.Arithmetic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.UI
{
    public class InventoryHolderScript : MonoBehaviour
    {
        Transform _transform;

        Transform ctl_inventory;

        RectTransform rt_ctl_inventory;
        float inventoryHeight;

        bool isInventoryVisible;
        bool isInAnimation;

        private void Awake()
        {
            isInventoryVisible = true;
            isInAnimation = false;
        }

        private void Start()
        {
            _transform = transform;

            ctl_inventory = _transform.FindChild("Inventory");

            rt_ctl_inventory = ctl_inventory.GetComponent<RectTransform>();

            inventoryHeight = rt_ctl_inventory.rect.height;
        }

        public void OnHideInventroyButtonClick()
        {
            if (!isInAnimation)
            {
                StartCoroutine(SwitchInventory(isInventoryVisible));
            }
        }

        IEnumerator SwitchInventory(bool isInventoryVisible)
        {
            isInAnimation = true;

            float percent = 0;

            Vector3 oldPos = _transform.localPosition;

            Interpolator interpolator = new DecelerateInterpolator(1.618f);
            float time = 0;

            Vector3 newPos = oldPos;
            while (1 - percent > 0.01f)
            {
                newPos.y = isInventoryVisible ? oldPos.y - percent * inventoryHeight : oldPos.y + percent * inventoryHeight;
                _transform.localPosition = newPos;

                percent = interpolator.GetInterpolation(time);
                time += TimeKits.deltaTime();

                yield return null;
            }

            _transform.localPosition = oldPos + (isInventoryVisible ? new Vector3(0, -inventoryHeight, 0) : new Vector3(0, inventoryHeight, 0));

            isInAnimation = false;
            this.isInventoryVisible = !this.isInventoryVisible;

            yield return null;
        }
    }
}
