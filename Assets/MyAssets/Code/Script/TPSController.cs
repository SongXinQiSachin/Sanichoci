using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sanichoci.Script
{
    public class TPSController : MonoBehaviour
    {
        public Transform body;
        public Transform head;

        public KeyCode moveForward = KeyCode.W;
        public KeyCode moveBack = KeyCode.S;
        public KeyCode moveLeft = KeyCode.A;
        public KeyCode moveRight = KeyCode.D;

        //private Transform _transform;
        //private Rigidbody _rigidbody;
        private CharacterController _characterController;

        private float mouseRotateX;
        //private float mouseRotateY;

        private Transform _head;

        // Use this for initialization
        void Start()
        {
            //_transform = base.transform;
            //_rigidbody = GetComponent<Rigidbody>();

            _head = transform.Find("Root/Ribs/Neck/Head");
            if (_head == null)
            {
                Debug.Log("Head is null");
            }
        }

        private void Update()
        {
            mouseRotateX = Input.GetAxis("Mouse X");
            //mouseRotateY = Input.GetAxis("Mouse Y");

            transform.Rotate(new Vector3(0, mouseRotateX * 10, 0));
            _head.transform.Rotate(new Vector3(mouseRotateX * 20, 0, 0));
            //Debug.Log(cameraX + "/" + cameraY);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (Input.GetKey(moveForward))
            {
                Debug.Log("W");
            }
            if (Input.GetKey(moveBack))
            {
                Debug.Log("S");
            }
            if (Input.GetKey(moveLeft))
            {
                Debug.Log("A");
            }
            if (Input.GetKey(moveRight))
            {
                Debug.Log("D");
            }
        }
    }
}
