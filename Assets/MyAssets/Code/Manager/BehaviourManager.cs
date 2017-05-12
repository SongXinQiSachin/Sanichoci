using Sanichoci.Component.GameObject;
using Sanichoci.Logic.Arithmetic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.Manager
{
    public partial class BehaviourManager : MonoBehaviour, IManager
    {
        private void Awake()
        {
            behaviourProxies = new BehaviourProxy[Enum.GetValues(typeof(BehaviourManager.Behaviour)).Length];
            behaviourProxies[GetBehaviourIndex(Behaviour.START)] += () => { };
            behaviourProxies[GetBehaviourIndex(Behaviour.UPDATE)] += () => { };
            behaviourProxies[GetBehaviourIndex(Behaviour.FIXED_UPDATE)] += () => { };

            instance = this;
        }

        private void Start()
        {
            //behaviourProxies[GetBehaviourIndex(Behaviour.START)]();
            //StartCoroutine(Test());
        }

        IEnumerator Test()
        {
            float cerp = 0;

            List<Vector3> points = new List<Vector3>();
            Vector3 lp = new Vector3();

            IInterpolator erp = new DecelerateInterpolator(1);

            while (true)
            {
                cerp += TimeManager.Instance.DeltaTime();

                float result = erp.GetInterpolation(cerp);
                points.Add(new Vector3(cerp, result));
                Debug.Log(cerp + " - " + result);

                Debug.DrawLine(new Vector3(0, 0), new Vector3(25, 0), Color.green);
                Debug.DrawLine(new Vector3(0, 0), new Vector3(0, 25), Color.blue);

                Debug.DrawLine(new Vector3(0, 1), new Vector3(25, 1), Color.green);
                Debug.DrawLine(new Vector3(0, 2), new Vector3(25, 2), Color.green);
                Debug.DrawLine(new Vector3(0, 3), new Vector3(25, 3), Color.green);
                Debug.DrawLine(new Vector3(0, 4), new Vector3(25, 4), Color.green);
                Debug.DrawLine(new Vector3(0, 5), new Vector3(25, 5), Color.green);
                Debug.DrawLine(new Vector3(0, 6), new Vector3(25, 6), Color.green);

                Debug.DrawLine(new Vector3(1, 0), new Vector3(1, 25), Color.green);
                Debug.DrawLine(new Vector3(2, 0), new Vector3(2, 25), Color.green);
                Debug.DrawLine(new Vector3(3, 0), new Vector3(3, 25), Color.green);
                Debug.DrawLine(new Vector3(4, 0), new Vector3(4, 25), Color.green);
                Debug.DrawLine(new Vector3(5, 0), new Vector3(5, 25), Color.green);
                Debug.DrawLine(new Vector3(6, 0), new Vector3(6, 25), Color.green);


                foreach (Vector3 p in points)
                {
                    Debug.DrawLine(lp, p, Color.red);
                    lp = p;
                }
                yield return null;
            }

            yield return null;
        }

        private void Update()
        {
        }

        private void FixedUpdate()
        {
            //behaviourProxies[GetBehaviourIndex(Behaviour.FIXED_UPDATE)]();
        }

        public void RegisgerBehaviourProxy(Behaviour behaviour, BehaviourProxy proxy)
        {
            behaviourProxies[GetBehaviourIndex(behaviour)] += proxy;
        }

        public void UnregisterBehaviourProxy(Behaviour behaviour, BehaviourProxy proxy)
        {
            behaviourProxies[GetBehaviourIndex(behaviour)] -= proxy;
        }

        private uint GetBehaviourIndex(Behaviour behaviour)
        {
            return (uint)behaviour;
        }

        public enum Behaviour : uint
        {
            START,
            UPDATE,
            FIXED_UPDATE
        }
    }
}
