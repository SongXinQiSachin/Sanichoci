using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Sanichoci.Manager
{
    public partial class UIManager : MonoBehaviour, IManager
    {
        private GameObject gameSceneUI;
        private Transform gameSceneUITransform;
        private Canvas gameSceneUICanvas;

        public GameObject GameSceneUI
        {
            get
            {
                return gameSceneUI;
            }

            set
            {
                gameSceneUI = value;
            }
        }

        public Transform GameSceneUITransform
        {
            get
            {
                return gameSceneUITransform;
            }

            set
            {
                gameSceneUITransform = value;
            }
        }

        public Canvas GameSceneUICanvas
        {
            get
            {
                return gameSceneUICanvas;
            }

            set
            {
                gameSceneUICanvas = value;
            }
        }

        private void Awake()
        {
            instance = this;
        }

        private void Start()
        {
            GameSceneUI = GameObject.Find("UI/Canvas/UI");
            GameSceneUITransform = GameSceneUI.transform;
            GameSceneUICanvas = GameObject.Find("UI/Canvas").GetComponent<Canvas>();
        }
    }
}
