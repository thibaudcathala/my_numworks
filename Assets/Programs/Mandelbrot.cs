using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KandinskyModule;
using MathModule;
using System.Numerics;

public class Mandelbrot : MonoBehaviour
{
    IEnumerator mandelbrot(int N_iteration)
    {
        for (int x = 0; x < kandinsky.render_texture.width; ++x)
        {
            for (int y = 0; y < kandinsky.render_texture.height; ++y)
            {
                Complex z = math.complex(0, 0);
                Complex c = math.complex(3.5 * x / 319 - 2.5, -2.5 * y / 221 + 1.25);
                int i = 0;

                while ((i < N_iteration) && z.Magnitude < 2)
                {
                    ++i;
                    z = z * z + c;
                }
                int rgb = 255 * i / N_iteration;
                Color col = kandinsky.color(rgb, (int)(rgb * 0.75), (int)(rgb * 0.25));
                kandinsky.set_pixel(x, y, col);
            }
            yield return null;
        }
    }

    void Start()
    {
        StartCoroutine(mandelbrot(100));
    }
}
