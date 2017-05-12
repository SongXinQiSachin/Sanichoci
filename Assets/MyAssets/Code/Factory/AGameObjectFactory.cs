using Sanichoci.Game;
using Sanichoci.Game.AGameObjectInstance;
using Sanichoci.Manager;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Sanichoci.Factory
{
    public class AGameObjectFactory
    {
        private static readonly string GAME_OBJECT_DATA_NAME_PREFIX = "Sanichoci.Game.AGameObjectInstance.AGameObject_";
        public static GameObject CreateGameObjectFromGameObjectDataName(string name)
        {
            object obj = ObjectFactory.CreateObjectFromName(GAME_OBJECT_DATA_NAME_PREFIX + name);

            if(obj == null)
            {
                Debug.LogError("Cannot create object : " + GAME_OBJECT_DATA_NAME_PREFIX + name);

                return null;
            }

            IAGameObject ago = (IAGameObject) obj;

            GameObject result = PoolManager.Instance.Spawn(ago.Prefab);

            result.transform.parent = StageManager.Instance.StageTransform;

            return result;
        }

        public static AbstractAGameObject CreateAGOFromAGOName(string name)
        {
            object obj = ObjectFactory.CreateObjectFromName(GAME_OBJECT_DATA_NAME_PREFIX + name);

            if(obj == null)
            {
                Debug.LogError("Cannot create object : " + GAME_OBJECT_DATA_NAME_PREFIX + name);

                return null;
            }

            return (AbstractAGameObject) obj;
        }

    }
}
