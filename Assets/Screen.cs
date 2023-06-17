using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.IO;
using KandinskyModule;

public class screen : MonoBehaviour
{
    public Texture2D screen_texture;

    void ini_kandinsky_class()
    {
        Kandinsky.render_texture = screen_texture;
    }

    void clear_screen()
    {
        for (int i = 0; i < screen_texture.width; ++i)
        {
            for (int j = 0; j < screen_texture.height; ++j)
            {
                screen_texture.SetPixel(i, j, Color.white);
            }
        }
        screen_texture.Apply();
    }

    void load_all_script()
    {
        string cwd = Directory.GetCurrentDirectory();
        cwd += "/Assets/Programs";
        string[] files = Directory.GetFiles(cwd, "*.cs");
        
        foreach (string file in files)
        {
            string filename = Path.GetFileNameWithoutExtension(file);
            GameObject new_obj = new GameObject(filename);
            new_obj.AddComponent(Type.GetType(filename));
            new_obj.transform.SetParent(GameObject.Find("Programs").transform);
        }
    }

    void Start()
    {
        Application.targetFrameRate = 60;

        screen_texture = GetComponent<SpriteRenderer>().sprite.texture;
        ini_kandinsky_class();
        clear_screen();
        load_all_script();
    }
}
