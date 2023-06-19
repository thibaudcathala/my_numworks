using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.IO;
using KandinskyModule;
using UnityEngine.UI;

public class screen : MonoBehaviour
{
    private Texture2D screen_texture;
    public GameObject program_list_obj;
    public GameObject button_prefab;

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

    void create_program_button(string program_name)
    {
        GameObject new_program_button = Instantiate(button_prefab, program_list_obj.transform);
        Text buttonText = new_program_button.GetComponentInChildren<Text>();
        if (buttonText != null)
        {
            // Change the text of the button
            buttonText.text = program_name;
        }
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
            new_obj.transform.SetParent(GameObject.Find("Programs").transform);
            //  new_obj.AddComponent(Type.GetType(filename));
            if (filename != null)
            {
                create_program_button(filename);
            }
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
