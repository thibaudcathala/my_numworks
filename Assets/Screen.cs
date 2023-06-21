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
    public Font text_font;

    void ini_kandinsky_class()
    {
        kandinsky.render_texture = screen_texture;
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

    void launch_program(string program_name)
    {
        GameObject obj = GameObject.Find("Programs");
        Debug.Log(program_name);
        if (obj != null)
        {
            obj.AddComponent(Type.GetType(program_name));
        }
        GameObject.Find("Menu").SetActive(false);
    }

    void create_program_button(string program_name)
    {
        GameObject new_program_button = Instantiate(button_prefab, program_list_obj.transform);
        Button program_button = new_program_button.GetComponent<Button>();
        Text button_text = new_program_button.GetComponentInChildren<Text>();

        program_button.onClick.AddListener(() => launch_program(program_name));
        if (button_text != null)
        {
            button_text.text = program_name;
            button_text.font = text_font;
            button_text.fontStyle = FontStyle.Bold;
            button_text.fontSize = 17;
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
            create_program_button(filename);
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
