using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public Text ScoreText;
    public GameObject MagicSword;
    public GameObject SwordPosition;
    public GameObject player_body;
    public GameObject player_head;
    private float interval;
    private float time = 0f;
    public int HP;
    public Slider slider;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        interval = 0.4f;
        HP = 100;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "SCORE:" + score;
        slider.value = HP;
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
        if (Input.GetKey(KeyCode.J))
        {
            time += Time.deltaTime;
            if (time > interval)
            {
                Instantiate(MagicSword, SwordPosition.transform.position, MagicSword.transform.rotation);
                time = 0f;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            HP -= 5;
            StartCoroutine("PlayerDamage");
        }
    }
    IEnumerator PlayerDamage()
    {
        for (int i = 0; i <3; i++)
        {
            player_body.SetActive(false);
            player_head.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            player_body.SetActive(true);
            player_head.SetActive(true);
            yield return new WaitForSeconds(0.1f);
        }
        
        
    }
}
