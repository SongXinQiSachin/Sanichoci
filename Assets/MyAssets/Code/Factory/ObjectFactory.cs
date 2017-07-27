using UnityEngine;
using System;

namespace Sanichoci.Factory
{
    public class ObjectFactory
    {
        public static object CreateObjectFromName(string typeName, object[] args)
        {
            Type type = Type.GetType(typeName);

            if (type == null)
            {
                return null;
            }
            object result = null;

            try
            {
                result = (null == args) ? Activator.CreateInstance(type) : Activator.CreateInstance(type, args);
            }
            catch (Exception e)
            {
                Debug.Log("Create \"" + typeName + "\" Error : " + e);
            }

            return result;
        }

        public static object CreateObjectFromName(string typeName)
        {
            return CreateObjectFromName(typeName, null);
        }
    }
}