using Sanichoci.Logic.Arithmetic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Sanichoci.Game;

namespace Sanichoci.UI
{
    public abstract class AbstractAGOTooltipWindow : AbstractUIComponent , IAGOTooltipWindow
    {
        public void FadeOut(float time)
        {
            StartCoroutine(FadeFunction(true, time));
        }
        public void FadeIn(float time)
        {
            StartCoroutine(FadeFunction(false, time));
        }

        IEnumerator FadeFunction(bool isOut, float time)
        {

            IArithmetic arithmetic = new Arithmetic(new DecelerateInterpolator(), time);
            arithmetic.Start(
                () => 
                {
                },
                (result) => 
                {
                    if (CanvasGroup != null)
                    {
                        CanvasGroup.alpha = isOut ? 1 - result : result;
                    }
                },
                () =>
                {
                }
                );

            yield return null;
        }

        public abstract void UpdateData(AbstractAGameObject obj);
    }
}
