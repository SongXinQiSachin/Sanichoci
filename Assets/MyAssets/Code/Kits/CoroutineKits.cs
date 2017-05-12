using Sanichoci.Manager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;

namespace Sanichoci.Kits
{
    public class CoroutineKits
    {
        public static void StartCoroutine(IEnumerator routine)
        {
            BehaviourManager.Instance.StartCoroutine(routine);
        }

        public static void PostDelay(float delay, UnityAction action)
        {
            StartCoroutine(DelayAction(delay, action));
        }

        static IEnumerator DelayAction(float delay, UnityAction action)
        {
            Debug.Log(Time.time);
            yield return new WaitForSecondsRealtime(delay);
            Debug.Log(Time.time);

            action();

            yield return null;
        }
    }
}
