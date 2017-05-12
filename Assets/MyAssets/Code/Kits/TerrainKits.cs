using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.Kits
{
    public class TerrainKits
    {
        public static float[,] GetHeightMap(Terrain terrain)
        {
            TerrainData terrainData = terrain.terrainData;
            return GetHeightMap(terrain, 0, terrainData.heightmapWidth, 0, terrainData.heightmapHeight, 0);

        }

        public static float[,] GetHeightMap(Terrain terrain, float xStart, int xEnd, float zStart, int zEnd)
        {
            return GetHeightMap(terrain, xStart, xEnd, zStart, zEnd, 0);
        }

        public static float[,] GetHeightMap(Terrain terrain, float xStart, int xEnd, float zStart, int zEnd, float offset)
        {
            if (null == terrain)
            {
                throw new NullReferenceException("Terrain is null");
            }

            TerrainData terrainData = terrain.terrainData;

            checkBounds(terrainData.heightmapWidth, terrainData.heightmapHeight, ref xStart, ref xEnd, ref zStart, ref zEnd);

            int width = xEnd;
            int length = zEnd;
            float[,] res = new float[width, length];

            Vector3 scale = terrainData.heightmapScale;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    res[i, j] = terrainData.GetHeight((int)((xStart + i) / scale.x), (int)((zStart + j) / scale.z)) + offset;
                }
            }

            return res;
        }

        private static void checkBounds(int terrainWidth, int terrainLength, ref float xStart, ref int xEnd, ref float zStart, ref int zEnd)
        {
            if (xStart < 0)
            {
                xStart = 0;
            }

            if (xEnd > terrainWidth)
            {
                xEnd = terrainWidth;
            }

            if (zStart < 0)
            {
                zStart = 0;
            }

            if (zEnd > terrainLength)
            {
                zEnd = terrainLength;
            }
        }
    }
}
