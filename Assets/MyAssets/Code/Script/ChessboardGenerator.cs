using Sanichoci.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sanichoci.Script
{
    public class ChessboardGenerator : MonoBehaviour
    {
        public GameObject normalGround = null;
        public float cellWidth = 10;
        public float cellHeight = 10;

        public int chessboardWidth = 11;
        public int chessboardHeight = 11;

        public bool generateAtCenter = true;

        private Transform _transform;

        private List<GameObject> temp;

        private void Awake()
        {
            temp = new List<GameObject>();
        }

        // Use this for initialization
        void Start()
        {
            _transform = base.transform;
            float baseHeight = _transform.position.y;

            float xOffset = 0;
            float zOffset = 0;
            if (generateAtCenter)
            {
                xOffset = (chessboardWidth % 2 == 1) ? -(chessboardWidth >> 1) * cellWidth : -(chessboardWidth >> 1) * cellWidth + cellWidth * 0.5f;
                zOffset = (chessboardHeight % 2 == 1)? -(chessboardHeight >> 1) * cellHeight : -(chessboardHeight >> 1) * cellHeight + cellHeight * 0.5f;
            }

            for (int i = 0; i < chessboardWidth; i++)
            {
                for (int j = 0; j < chessboardHeight; j++)
                {
                    GameObject obj = PoolManager.Instance.Spawn(normalGround);
                    obj.transform.position = new Vector3(xOffset + i * cellWidth, baseHeight, zOffset + j * cellHeight);
                    obj.transform.parent = _transform;
                    temp.Add(obj);
                }
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
