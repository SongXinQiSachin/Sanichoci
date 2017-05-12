using Sanichoci.Factory;
using Sanichoci.Game;
using Sanichoci.Game.AGameObjectInstance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.Component.GameObject
{
    public class AGameObjectComponent : MonoBehaviour
    {
        public AbstractAGameObject _ago;

        private void Start()
        {
            string curName = gameObject.name;
            if (curName.IndexOf("(Clone)") > 0)
            {
                curName = curName.Substring(0, curName.Length - 7);
            }

            _ago = AGameObjectFactory.CreateAGOFromAGOName(curName);
            if (null == _ago)
            {
                Debug.LogError("Create AGO error, please check your prefab's name and AGOInstance's file name, they should be same");
            }

            Type sd = _ago.GetType();

            Debug.Log(sd);

            if  (_ago is IUnit)
            {
                gameObject.AddComponent<UnitEventTriggerComponent>();
            }
            if  (_ago is ITerrain)
            {
                gameObject.AddComponent<TerrainEventHandlerComponent>();
            }
        }
    }
}
