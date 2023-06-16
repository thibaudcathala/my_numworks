using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

namespace KandinskyModule
{
    public class Kandinsky : MonoBehaviour
    {
        public static Color get_pixel(int x, int y)
        {
            Texture2D render_texture = GameObject.Find("Screen").GetComponent<screen>().screen_texture;

            return render_texture.GetPixel(x, y - render_texture.height);
        }

        public static void set_pixel(int x, int y, Color color)
        {
            Texture2D render_texture = GameObject.Find("Screen").GetComponent<screen>().screen_texture;

            render_texture.SetPixel(x, y - render_texture.height, color);
            render_texture.Apply();
        }
    }
}
