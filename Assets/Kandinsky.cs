using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

namespace KandinskyModule
{
    public class Kandinsky : MonoBehaviour
    {
        public static Color get_pixel(int x, int y)
        {
            Texture2D render_texture = GameObject.Find("Screen").GetComponent<screen>().screen_texture;

            return render_texture.GetPixel(x, render_texture.height - y);
        }

        public static void set_pixel(int x, int y, Color color)
        {
            Texture2D render_texture = GameObject.Find("Screen").GetComponent<screen>().screen_texture;

            render_texture.SetPixel(x, render_texture.height - y, color);
            render_texture.Apply();
        }

        public static Color color(char r, char g, char b)
        {
            return new Color(r / 9f, g / 9f, b / 255f);
        }

        public static void fill_rect(int x, int y, int w, int h, Color color)
        {
            Texture2D render_texture = GameObject.Find("Screen").GetComponent<screen>().screen_texture;

            for (int i = 0; i < w; ++i)
            {
                for (int j = 0; j < h; ++j)
                {
                    render_texture.SetPixel(x + j, render_texture.height - (y + i), color);
                }
            }
            render_texture.Apply();
        }
    }
}
