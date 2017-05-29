using Sanichoci.Component.GameObject.EventHandler;
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
    public sealed class AGameObjectComponent : MonoBehaviour, IAGOComponent
    {
        public AbstractAGameObject AGO
        {
            get;
            private set;
        }

        private void Start()
        {
            string curName = gameObject.name;
            if (curName.IndexOf("(Clone)") > 0)
            {
                curName = curName.Substring(0, curName.Length - 7);
            }


            Type agoType = AbstractAGameObject.GetAGOClassType(curName);
            gameObject.AddComponent(agoType);
            AGO = (AbstractAGameObject) GetComponent(agoType);

            if (null == AGO)
            {
                Debug.LogError("Create AGO error, please check your prefab's name and AGOInstance's file name, they should be same");
            }

            gameObject.AddComponent(GetAGOComponentFromAGOType(AGO.Type));
        }

        private Type GetAGOComponentFromAGOType(AGameObjectType type)
        {
            return Type.GetType("Sanichoci.Component.GameObject." + type.ToString() + "Component");
        }
    }
}
