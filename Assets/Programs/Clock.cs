using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KandinskyModule;
using RandomModule;

public class Test : MonoBehaviour
{
    private float size_clock = 75f;
    private Color clock_color = Color.red;
    private Color hour_color = Color.black;
    private Color min_color = Color.black;
    private Color sec_color = Color.black;

    void draw_hand(float hand_angle, float hand_scale, Color color)
    {
        Vector2 hour_hand_pos = new Vector2(
            (size_clock * hand_scale) * Mathf.Cos(hand_angle),
            (size_clock * hand_scale) * Mathf.Sin(hand_angle)
        );

        hour_hand_pos += kandinsky.get_center_screen();
        hour_hand_pos.y = kandinsky.flip_y(hour_hand_pos.y);
        kandinsky.draw_line(kandinsky.get_center_screen(), hour_hand_pos, color);
    }

    IEnumerator display_clock()
    {
        while (true)
        {
            kandinsky.draw_circle(kandinsky.get_center_screen(), size_clock, clock_color);

            float hour_angle = Mathf.PI / 2f - Mathf.PI / 6f * System.DateTime.Now.Hour;
            float minute_angle = Mathf.PI / 2f - Mathf.PI / 30f * System.DateTime.Now.Minute;
            float second_angle = Mathf.PI / 2f - Mathf.PI / 30f * System.DateTime.Now.Second;

            draw_hand(second_angle, 1f, sec_color);
            draw_hand(minute_angle, 0.8f, min_color);
            draw_hand(hour_angle, 0.6f, hour_color);

            yield return null;

            kandinsky.clear_screen();
        }
    }

    void Start()
    {
        StartCoroutine(display_clock());
    }
}
