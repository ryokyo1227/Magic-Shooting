using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy1 : MonoBehaviour
{
    public GameObject Enemy1;
    private float interval;
    private float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        interval = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > interval)
        {
            GameObject Enemy1s;
            Enemy1s = GameObject.Instantiate(Enemy1);
            Enemy1s.transform.position = transform.position;
            time = 0f;
        }
        
    }
}
