using Sanichoci.Kits;
using Sanichoci.Manager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.Component.GameObject
{
    [RequireComponent(typeof(Rigidbody))]
    public class SimpleMoveComponent : MonoBehaviour
    {
        [SerializeField]
        public float movespeed = 1f;

        private Transform _transform;
        private Rigidbody _rigidbody;
        private Animator _animator;

        private Vector3 currentTargetPosition;

        private void Start()
        {
            _transform = base.transform;
            _rigidbody = GetComponent<Rigidbody>();

            _animator = GetComponent<Animator>();
        }

        public void MoveTo(Vector3 target)
        {
            _animator.SetBool("Move", true);
            //_animator.speed = movespeed * .382f;
            currentTargetPosition = target;

            StartCoroutine(Rotate());
            StartCoroutine(Move());
        }

        private int times = 0;

        private IEnumerator Rotate()
        {
            times++;
            var localcurrentTargetPosition = transform.InverseTransformPoint(currentTargetPosition);
            float angle = Mathf.Atan2(localcurrentTargetPosition.x, localcurrentTargetPosition.z) * Mathf.Rad2Deg;
            while (times < 2 && Vector3.Distance(currentTargetPosition, _transform.position) > 0.06f)
            {
                localcurrentTargetPosition = transform.InverseTransformPoint(currentTargetPosition);
                angle = Mathf.Atan2(localcurrentTargetPosition.x, localcurrentTargetPosition.z) * Mathf.Rad2Deg;

                var eulerAngleVelocity = new Vector3(0, angle, 0);
                var deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime * 3.382f);
                _rigidbody.MoveRotation(_rigidbody.rotation * deltaRotation);

                yield return new WaitForFixedUpdate();
            }
            times--;
        }

        private IEnumerator Move()
        {
            while (Vector3.Distance(currentTargetPosition, _transform.position) > 0.06f)
            {
                // TODO: turn true to faceToTarget
                var localcurrentTargetPosition = transform.InverseTransformPoint(currentTargetPosition);
                float angle = Mathf.Atan2(localcurrentTargetPosition.x, localcurrentTargetPosition.z) * Mathf.Rad2Deg;
                if (angle > -87.5f && angle < 87.5f)
                {
                    Vector3 currentPosition = _transform.position;
                    currentPosition = Vector3.MoveTowards(currentPosition, currentTargetPosition, movespeed * TimeKits.deltaTime());
                    _rigidbody.MovePosition(currentPosition);
                }
                yield return new WaitForFixedUpdate();
            }
            _animator.SetBool("Move", false);
        }
    }
}
