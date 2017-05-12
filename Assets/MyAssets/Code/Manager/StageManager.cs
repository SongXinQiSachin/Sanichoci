using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Sanichoci.Manager
{
    public partial class StageManager : MonoBehaviour, IManager
    {
        private GameObject stage;
        private Transform stageTransform;

        public GameObject Stage
        {
            get
            {
                return stage;
            }

            private set
            {
                stage = value;
            }
        }

        public Transform StageTransform
        {
            get
            {
                return stageTransform;
            }

            private set
            {
                stageTransform = value;
            }
        }

        private void Awake()
        {
            instance = this;
        }

        private void Start()
        {
            Stage = GameObject.Find("Stage");
            StageTransform = Stage.transform;
        }
    }
}
