using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sanichoci.Kits
{

    public class MeshKit
    {
        public static void ApplyHeightMapToMesh(float[,] heightMap, ref Mesh mesh)
        {
            if (heightMap == null)
            {
                return;
            }
            if (null == mesh)
            {
                mesh = null;
            }

            Vector3[] vertices = mesh.vertices;
            int width = (int)Mathf.Sqrt(vertices.Length);
            for (int xi = 0; xi < width; xi++)
            {
                for (int yi = 0; yi < width; yi++)
                {
                    int index = xi * width + yi;
                    try
                    {
                        vertices[vertices.Length - index - 1].y = heightMap[xi, yi];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Debug.Log("index : " + index + " | " +  "width : " + width + " | x/y : " + xi + "," + yi + " | in : " + vertices.Length);
                    }
                }
            }

            mesh.vertices = vertices;
        }
    }
}
