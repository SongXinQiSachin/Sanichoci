using Sanichoci.Kits;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Sanichoci.Logic.Arithmetic
{
    public class SimpleDecelerateArithmetic
    {
        float start;
        public SimpleDecelerateArithmetic(float start)
        {
            this.start = start;
        }

        public void Start(ArithmeticResult result, ArithmeticEnd end)
        {
            CoroutineKits.StartCoroutine(Calcuate(result, end));
        }

        IEnumerator Calcuate(ArithmeticResult result, ArithmeticEnd end)
        {
            float percent = 0;

            Interpolator interpolator = new DecelerateInterpolator(1);
            float time = 0;

            while (1 - percent > 0.0001f)
            {
                percent = interpolator.GetInterpolation(time);
                time += TimeKits.deltaTime();
                result(percent);

                yield return null;
            }
            end();
            yield return null;
        }

        public delegate void ArithmeticResult(float value);
        public delegate void ArithmeticEnd();
    }
}
