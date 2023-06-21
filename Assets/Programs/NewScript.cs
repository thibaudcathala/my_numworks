using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KandinskyModule;
using RandomModule;
using MathModule;

public class MyNewScript : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(main_func());
    }

    IEnumerator main_func()
    {
        Vector2 center = kandinsky.get_center_screen();
        float radius = random.randint(1, 100);
        Color color = kandinsky.color(255, 0, 0);

        kandinsky.draw_circle(center, radius, color);
        yield return null;
    }
}
