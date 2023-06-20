using KandinskyModule;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RandomModule
{
    public class random : MonoBehaviour
    {
        public static int randint(int min, int max)
        {
            return UnityEngine.Random.Range(min, max + 1);
        }

        public static Vector2 randpoint()
        {
            return new Vector2(
                randint(0, kandinsky.render_texture.width),
                randint(0, kandinsky.render_texture.height)
            );
        }

        public static Color randcolor()
        {
            return kandinsky.color(randint(0, 255), randint(0, 255), randint(0, 255));
        }
    }
}
