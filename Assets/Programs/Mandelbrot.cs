using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KandinskyModule;
using MathModule;
using stdModule;
using System.Numerics;

public class Mandelbrot : MonoBehaviour
{
    int N_iteration = 1000;
    int x = 0;
    int y = 0;

    Color compute_mandelbrot()
    {
        Complex z = Math.complex(0, 0);
        Complex c = Math.complex(3.5 * x / 319 - 2.5, -2.5 * y / 221 + 1.25);
        int i = 0;

        while ((i < N_iteration) && z.Magnitude < 2)
        {
            ++i;
            z = z * z + c;
        }
        int rgb = 255 * i / N_iteration;
        return Kandinsky.color(rgb, (int)(rgb * 0.75), (int)(rgb * 0.25));
    }

    void display_mandelbrot()
    {
        Kandinsky.set_pixel(x, y, compute_mandelbrot());
    }

    private bool shouldContinue = true;

    private IEnumerator MyCoroutine()
    {
        // Do some initial work

        while (shouldContinue)
        {
            // Perform some work
            
            for (int i = 0; i < Kandinsky.render_texture.width; ++i)
            {
                for (int j = 0; j < Kandinsky.render_texture.height; ++j)
                {
                    Kandinsky.set_pixel(i, j, Color.red);
                }
                yield return null;
            }
            // Yield to render a frame and continue in the next frame
        }
        // Execution continues here after the coroutine is stopped
    }

    private void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    void Update()
    {
        //        std.for_each_pixel(ref x, ref y, 100, display_mandelbrot);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shouldContinue = false;
        }
    }
}
