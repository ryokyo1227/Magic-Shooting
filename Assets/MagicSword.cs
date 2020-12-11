using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicSword : MonoBehaviour
{
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody.AddForce(Vector3.forward * 300);
        Destroy(this.gameObject, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
