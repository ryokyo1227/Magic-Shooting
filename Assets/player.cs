using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject MagicSword;
    public GameObject SwordPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if(transform.position.y<3.9f)
                {
                transform.position += new Vector3(0, 0.2f, 0);
            }

        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -2.4f)
            {
                transform.position -= new Vector3(0, 0.2f, 0);
            }
          
        }
        if (Input.GetKey(KeyCode.D))
        {
            if(transform.position.x < 4.6f)
            {
                transform.position += new Vector3(0.2f, 0, 0);
            }
        
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -4.6f)
            {
                transform.position -= new Vector3(0.2f, 0, 0);
            }
       
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(MagicSword, SwordPosition.transform.position,MagicSword.transform.rotation);
        }
    }
}
