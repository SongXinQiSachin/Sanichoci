using Sanichoci.Game.Interface;
using System;
using UnityEngine;

namespace Sanichoci.Game
{
    public class AbstractAGameObject :
        MonoBehaviour,
        ICrossable,
        IAGameObject, IType, IInWhicnFloor,
        IDescribable,
        ILevel,
        IAGameObjectLifeCycle
    {
        private void Awake()
        {
            Type = AGameObjectType.None;

            InWhichFloor = -999;

            Name = "Default AGO Name";

            Description = "Default AGO Description";

            Level = -1;
        }

        private void Start()
        {
            OnCreate();
        }

        private void FixedUpdate()
        {
            OnUpdate();
        }

        public virtual AGameObjectType Type { get; set; }

        public virtual long InWhichFloor { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual int Level { get; set; }

        public virtual bool Crossable { get; set; }

        public string GetBasicName()
        {
            string name = GetType().ToString();
            int index = name.IndexOf("_");
            name = name.Substring(index + 1, name.Length - index - 1);

            return name;
        }

        public static Type GetAGOClassType(string oriName)
        {
            return System.Type.GetType("Sanichoci.Game.AGameObjectInstance.AGameObject_" + oriName);
        }

        public static AGameObjectType ParseAGOType(string oriName)
        {
            if (oriName.IndexOf("AGameObject_") != -1)
            {
                oriName = oriName.Substring(12);
            }

            string type = oriName.Substring(0, oriName.IndexOf("_"));

            AGameObjectType agoType = AGameObjectType.None;
            try
            {
                agoType = (AGameObjectType)Enum.Parse(typeof(AGameObjectType), type);
            } 
            catch (Exception e)
            {
                Debug.LogError("ParseAGOType Error : " + oriName);
                Debug.LogError("ParseAGOType Error : " + e);
            }

            return agoType;
        }

        public virtual void OnCreate()
        {
        }

        public virtual void OnDestroy()
        {
        }

        public virtual void OnUpdate()
        {
        }
    }
}
