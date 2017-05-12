using Sanichoci.Kits;
using Sanichoci.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Sanichoci.Script.Camera
{
    public class PlanformCameraScript : MonoBehaviour
    {
        public float angle = 66f;
        public float height = 5f;

        [SerializeField]
        public float dragPercent = 0.0382f;

        public float arrowMoveSpeed = 0.0382f;

        private Transform _transform;

        private Vector3 dragStartCameraPosition;
        private Vector3 dragStartControllerPosition;

        // Use this for initialization
        void Start()
        {
            _transform = base.transform;

            dragStartCameraPosition = new Vector3();
            dragStartControllerPosition = new Vector3();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Fire3"))
            {
                dragStartCameraPosition = _transform.position;
                dragStartControllerPosition = Input.mousePosition;
            }

            if (Input.GetButton("Fire3"))
            {
                ApplyDragMove();
            }
            else
            {
                //ApplyBoundMove();
            }

            ApplyArrowMove();


            Vector3 pos = _transform.position;
            pos.y = height;
            transform.SetPositionAndRotation(pos, Quaternion.Euler(angle, 0, 0));
        }

        private void ApplyArrowMove()
        {
            Vector3 curPosition = _transform.position;
            if (InputManager.Instance.IsKeyHold(KeyCode.UpArrow))
            {
                curPosition.z += arrowMoveSpeed;
            }
            if (InputManager.Instance.IsKeyHold(KeyCode.DownArrow))
            {
                curPosition.z -= arrowMoveSpeed;
            }
            if (InputManager.Instance.IsKeyHold(KeyCode.RightArrow))
            {
                curPosition.x += arrowMoveSpeed;
            }
            if (InputManager.Instance.IsKeyHold(KeyCode.LeftArrow))
            {
                curPosition.x -= arrowMoveSpeed;
            }

            transform.SetPositionAndRotation(curPosition, Quaternion.Euler(angle, 0, 0));
        }

        private void ApplyBoundMove()
        {
            Vector3 curPosition = _transform.position;
            Vector3 mousePosition = Input.mousePosition;

            float screenMaxX = ScreenKits.GetWidth();
            float screenMaxY = ScreenKits.GetHeight();

            if (mousePosition.x < 4)
            {
                curPosition.x -= 0.25f;
            }
            if (mousePosition.x > screenMaxX - 4)
            {
                curPosition.x += 0.25f;
            }

            if (mousePosition.y < 4)
            {
                curPosition.z -= 0.25f;
            }
            if (mousePosition.y > screenMaxY - 4)
            {
                curPosition.z += 0.25f;
            }

            Cursor.lockState = CursorLockMode.Confined;

            curPosition.y = height;

            transform.SetPositionAndRotation(curPosition, Quaternion.Euler(angle, 0, 0));
        }

        private void ApplyDragMove()
        {
            Vector3 curPosition = _transform.position;
            Vector3 controllerPosition = Input.mousePosition;

            curPosition.x = (dragStartCameraPosition.x - (controllerPosition.x - dragStartControllerPosition.x) * dragPercent);
            curPosition.y = height;
            curPosition.z = (dragStartCameraPosition.z - (controllerPosition.y - dragStartControllerPosition.y) * dragPercent);

            transform.SetPositionAndRotation(curPosition, Quaternion.Euler(angle, 0, 0));
        }
    }
}
