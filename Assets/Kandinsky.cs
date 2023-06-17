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
        public static Texture2D render_texture;

        public static Color get_pixel(int x, int y)
        {
            return render_texture.GetPixel(x, render_texture.height - (y + 1));
        }

        public static void set_pixel(int x, int y, Color color)
        {
            render_texture.SetPixel(x, render_texture.height - (y + 1), color);
            render_texture.Apply();
        }

        public static Color color(int r, int g, int b)
        {
            return new Color(r / 255f, g / 255f, b / 255f);
        }

        public static void fill_rect(int x, int y, int w, int h, Color color)
        {
            for (int i = 0; i < w; ++i)
            {
                for (int j = 0; j < h; ++j)
                {
                    render_texture.SetPixel(x + j, render_texture.height - ((y + 1) + i), color);
                }
            }
            render_texture.Apply();
        }
    }
}
