using Sanichoci.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Sanichoci.Game.AGameObjectInstance
{
    public class AGameObject_DummyItem : AGameObject_AbstractItem
    {
        public override ItemType ItemType
        {
            get
            {
                return ItemType.PassiveNormal;
            }
        }

        public override string Name
        {
            get
            {
                return "DummyItem";
            }
        }

        public override GameObject Prefab
        {
            get
            {
                return PrefabManager.Instance.DummyItem;
            }
        }
    }
}
