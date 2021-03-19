using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    player p;
    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<player>();
        float y = Random.Range(-1.5f, 4.0f);
        float z = Random.Range(17.9f, 17.31f);
        transform.position = new Vector3(0,y, z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0, 0.3f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MagicSword")
        {
            p.score += 5;
            p.MP += 1;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
