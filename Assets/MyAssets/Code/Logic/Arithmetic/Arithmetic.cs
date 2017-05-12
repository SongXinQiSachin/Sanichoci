using Sanichoci.Kits;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Sanichoci.Logic.Arithmetic
{
    public class Arithmetic : IArithmetic
    {
        private float duration;
        private IInterpolator interpolator;

        private bool pause;
        private bool stop;

        public Arithmetic(IInterpolator interpolator, float duration)
        {
            this.interpolator = interpolator;
            this.duration = duration;
        }

        public void Start(ArithmeticTimePoint start, ArithmeticResult result, ArithmeticTimePoint end)
        {
            pause = false;
            stop = false;
            CoroutineKits.StartCoroutine(Calcuate(start, result, end));
        }

        public void Pause()
        {
            pause = true;
        }

        public void Resume()
        {
            pause = false;
        }

        public void Stop()
        {
            stop = true;
        }

        IEnumerator Calcuate(ArithmeticTimePoint start, ArithmeticResult result, ArithmeticTimePoint end)
        {
            start();

            float percent = 0;
            float time = 0;

            while (!stop)
            {
                if (pause)
                {
                    continue;
                }

                percent = interpolator.GetInterpolation(time);
                if (percent > 0.999f)
                {
                    percent = 1;
                    result(percent);
                    end();
                    break;
                }
                result(percent);

                time += (TimeKits.deltaTime() / duration);

                yield return null;
            }

            if (!stop)
            {
                stop = true;
                end();
            }

            yield return null;
        }
    }
}
