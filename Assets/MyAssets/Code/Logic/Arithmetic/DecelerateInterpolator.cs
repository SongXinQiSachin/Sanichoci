using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Logic.Arithmetic
{
    public class DecelerateInterpolator : Interpolator
    {
        private float factor;

        public DecelerateInterpolator()
        {
            factor = 1.0f;
        }

        public DecelerateInterpolator(float factor)
        {
            this.factor = factor;
        }

        public override float GetInterpolation(float input)
        {
            float result;
            if (factor == 1.0f)
            {
                result = (float)(1.0f - (1.0f - input) * (1.0f - input));
            }
            else
            {
                result = (float)(1.0f - Math.Pow((1.0f - input), 2 * factor));
            }
            return result;
        }
    }
}
