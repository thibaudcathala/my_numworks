using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KandinskyModule;

public class Test: MonoBehaviour
{
    void Start()
    {
        Kandinsky.set_pixel(50, 50, Color.red);
        Kandinsky.fill_rect(100, 100, 50, 50, Color.blue);
    }
}
