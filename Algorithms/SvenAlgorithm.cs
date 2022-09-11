using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class SvenAlgorithm
    {
        public SvenAlgorithm()
        {

        }

        public (double a, double b) GetMaximumExtremumRange(Func<double, double> func, double initialX, double step)
        {
            //step1
            var fx = func(initialX);
            var fxPosStep = func(initialX + step);
            var fxNegStep = func(initialX - step);
            int k = 1;
            double a = 0.0;
            double b = 0.0;

            //step2
            double xK = 0.0;
            double xKMinus1 = initialX;
            double xKPlus1 = 0.0;
            if (fxNegStep <= fx && fx <= fxPosStep)
            {
                xK = initialX + step;
                //To step4
            }
            //step3
            else if (fxNegStep >= fx && fx >= fxPosStep)
            {
                xK = initialX - step;
                step = -step;
                //To step4
            }
            else if(fxNegStep <= fx && fx >= fxPosStep)
            {
                a = initialX - step;
                b = initialX + step;
                return (a, b);
            }
            //step 4-5
            do
            {
                xKPlus1 = xK + Math.Pow(2, k) * step;
                k++;
            }
            while (func(xKPlus1) >= func(xK));            

            //step6
            
            if (step > 0)
            {
                a = xKMinus1;
                b = xKPlus1;
            }
            else
            {
                a = xKPlus1;
                b = xKMinus1;
            }
            return (a, b);
        }
    }
}
