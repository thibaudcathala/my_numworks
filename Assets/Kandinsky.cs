using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

namespace KandinskyModule
{
    public class kandinsky : MonoBehaviour
    {
        public static Texture2D render_texture;

        public static Vector2 get_center_screen()
        {
            return new Vector2(render_texture.width / 2f, render_texture.height / 2f);
        }

        public static float flip_y(float y)
        {
            return render_texture.height - y;
        }

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

        public static Vector2 to_vector2(int x, int y)
        {
            return new Vector2(x, y);
        }

        public static void draw_line(Vector2 start, Vector2 end, Color color)
        {
            Vector2 direction = (end - start).normalized;
            float distance = Vector2.Distance(start, end);

            for (float t = 0; t < distance; t += 1f)
            {
                int x = Mathf.RoundToInt(start.x + direction.x * t);
                int y = Mathf.RoundToInt(start.y + direction.y * t);

                if (x >= 0 && x < render_texture.width && y >= 0 && y < render_texture.height)
                {
                    render_texture.SetPixel(x, render_texture.height - (y + 1), color);
                }
            }

            render_texture.Apply();
        }

        public static void draw_circle(Vector2 center, float radius, Color color)
        {
            int segments = 360;
            float angleIncrement = 360f / segments;

            for (int i = 0; i < segments; i++)
            {
                float angle = i * angleIncrement;
                float x = center.x + radius * Mathf.Cos(angle * Mathf.Deg2Rad);
                float y = center.y + radius * Mathf.Sin(angle * Mathf.Deg2Rad);

                render_texture.SetPixel(Mathf.RoundToInt(x), render_texture.height - (Mathf.RoundToInt(y) + 1), color);
            }
            render_texture.Apply();
        }

        public static void clear_screen()
        {
            Color32[] pixels = render_texture.GetPixels32();

            for (int i = 0; i < pixels.Length; ++i)
            {
                pixels[i] = Color.white;
            }
            render_texture.SetPixels32(pixels);
            render_texture.Apply();
        }
    }
}
