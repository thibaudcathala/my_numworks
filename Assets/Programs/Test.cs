using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KandinskyModule;

public class Test: MonoBehaviour
{
    void Start()
    {
        Kandinsky.set_pixel(0, 0, Color.red);
    }
}
