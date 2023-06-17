using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KandinskyModule;

namespace stdModule
{
    public class std : MonoBehaviour
    {
        public delegate void function_t();

        public static void for_each_pixel(ref int x, ref int y, int process_by_frame, function_t function)
        {
            for (int frame = 0; frame < process_by_frame; ++frame)
            {
                if (x < 320 && y <= 222)
                {
                    function();
                    ++y;
                    if (y > 222)
                    {
                        y = 0;
                        ++x;
                    }
                }
            }
        }
    }
}
