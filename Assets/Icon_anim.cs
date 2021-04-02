using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Icon_anim : MonoBehaviour
{
    public Image Sh_image;
    public Sprite[] Sh_sprite;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        InvokeRepeating("Anim", 0, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Anim()
    {
        Sh_image.sprite = Sh_sprite[index];
        index++;
        if (index >= Sh_sprite.Length)
        {
            index = 0;
        }
    }
}
