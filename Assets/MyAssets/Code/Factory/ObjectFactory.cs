using UnityEngine;
using UnityEditor;
using System;

namespace Sanichoci.Factory
{
    public class ObjectFactory
    {
        public static object CreateObjectFromName(string typeName)
        {
            Type type = Type.GetType(typeName);

            if (type == null)
            {
                return null;
            }
            object result = null;

            try
            {
                result = Activator.CreateInstance(type);
            }
            catch (Exception e)
            {
                Debug.Log("Create Object Error : " + e);
            }

            return result;
        }
    }
}