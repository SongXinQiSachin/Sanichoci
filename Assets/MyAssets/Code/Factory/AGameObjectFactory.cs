using Sanichoci.Game;
using Sanichoci.Manager;
using Sanichoci.OGO.AGO;
using Sanichoci.OGO.AGO.TerrainBlock;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;


namespace Sanichoci.Factory
{
    public class AGameObjectFactory
    {
        public static GameObject CreateAGO(string name)
        {
            AGOType type = AbstractAGO.ParseAGOType(name);

            Debug.Log(type);

            MethodInfo createFunc = typeof(AGameObjectFactory).GetMethod("Create" + type.ToString());

            GameObject obj = (GameObject) createFunc.Invoke(null, new string[] { name });

            return obj;
        }

        public static GameObject CreateUnit(string name)
        {
            GameObject prefab = UnitPrefabManager.Instance.GetPrefabFromName(name);
            GameObject obj = CreateStageObject(prefab);
            return obj;
        }

        public static GameObject CreateItem(string name)
        {
            GameObject prefab = ItemPrefabManager.Instance.GetPrefabFromName(name);
            GameObject obj = CreateStageObject(prefab);
            return obj;
        }

        protected static GameObject CreateStageObject(GameObject prefab)
        {
            GameObject obj = PoolManager.Instance.Spawn(prefab);
            obj.transform.parent = StageManager.Instance.StageTransform;
            return obj;
        }

        //private static readonly string GAME_OBJECT_DATA_NAME_PREFIX = "Sanichoci.Game.AGameObjectInstance.AGameObject_";

        //public static GameObject CreateGameObjectFromGameObjectDataName(string name)
        //{
        //    object obj = ObjectFactory.CreateObjectFromName(GAME_OBJECT_DATA_NAME_PREFIX + name);

        //    if(obj == null)
        //    {
        //        Debug.LogError("Cannot create object : " + GAME_OBJECT_DATA_NAME_PREFIX + name);

        //        return null;
        //    }

        //    IAGameObject ago = (IAGameObject) obj;

        //    GameObject result = PoolManager.Instance.Spawn(ago.Prefab);

        //    result.transform.parent = StageManager.Instance.StageTransform;

        //    return result;
        //}

        //public static AbstractAGameObject CreateAGOFromAGOName(string name)
        //{
        //    object obj = ObjectFactory.CreateObjectFromName(GAME_OBJECT_DATA_NAME_PREFIX + name);

        //    if(obj == null)
        //    {
        //        Debug.LogError("Cannot create object : " + GAME_OBJECT_DATA_NAME_PREFIX + name);

        //        return null;
        //    }

        //    return (AbstractAGameObject) obj;
        //}

    }
}
