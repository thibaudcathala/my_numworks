using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Numerics;

namespace MathModule
{
    public class Math : MonoBehaviour
    {
        public static double abs(double x)
        {
            if (x < 0)
            {
                return -x;
            }
            return x;
        }

        public static Complex complex(double a, double b)
        {
            return new Complex(a, b);
        }
    }
}