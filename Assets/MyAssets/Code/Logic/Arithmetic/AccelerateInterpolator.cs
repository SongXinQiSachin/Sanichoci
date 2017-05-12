using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Logic.Arithmetic
{
    public class AccelerateInterpolator : Interpolator
    {
        private float factor;
        private float doubleFactor;

        public AccelerateInterpolator()
        {
            factor = 1.0f;
            doubleFactor = 2 * factor;
        }

        public AccelerateInterpolator(float factor)
        {
            this.factor = factor;
            doubleFactor = 2 * this.factor;

        }

        public override float GetInterpolation(float input)
        {
            if (factor == 1.0f)
            {
                return input * input;
            }
            else
            {
                return (float)Math.Pow(input, doubleFactor);
            }
        }
    }
}
