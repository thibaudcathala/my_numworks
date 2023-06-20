using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using KandinskyModule;
using RandomModule;

public class Test : MonoBehaviour
{
    IEnumerator my_test()
    {
        for (int i = 0; i < 30; ++i)
        {
            kandinsky.draw_circle(random.randpoint(), random.randint(1, 50), random.randcolor());
            kandinsky.draw_line(random.randpoint(), random.randpoint(), random.randcolor());
            yield return new WaitForSeconds(0.2f);
        }
    }

    void Start()
    {
        StartCoroutine(my_test());
    }
}
