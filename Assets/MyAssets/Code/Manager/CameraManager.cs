using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.Manager
{
    public partial class CameraManager : MonoBehaviour, IManager
    {
        private Camera currentCamera;
        private Camera mainCamera;

        private void Awake()
        {
            instance = this;
        }

        private void Start()
        {
            CurrentCamera = Camera.main;
            MainCamera = Camera.main;

            StartCoroutine(MonitorResetCameraCommand());
        }

        IEnumerator MonitorResetCameraCommand()
        {
            while (!GameManager.Instance.IsExit)
            {
                InputManager.Instance.WaitForDoubleClick(KeyCode.F1, () =>
                {
                    if (GlobalUnitSelectedManager.Instance.CurrentSelectedUnit != null)
                    {
                        Vector3 pos = CameraManager.Instance.CurrentCamera.transform.position;
                        Vector3 pos2 = GlobalUnitSelectedManager.Instance.CurrentSelectedUnit.transform.position;
                        pos.x = pos2.x;
                        pos.z = pos2.z - CameraManager.Instance.CurrentCamera.transform.position.y / 2;

                        CameraManager.Instance.CurrentCamera.transform.position = pos;
                    }
                });
                yield return null;
            }
            yield return 0;
        }

        public Camera CurrentCamera
        {
            get
            {
                return currentCamera;
            }

            set
            {
                currentCamera = value;
            }
        }
        public Camera MainCamera
        {
            get
            {
                return mainCamera;
            }

            private set
            {
                mainCamera = value;
            }
        }
    }
}
