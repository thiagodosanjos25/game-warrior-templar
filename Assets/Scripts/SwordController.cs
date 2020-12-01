using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{
 

    private Rigidbody2D _rb2dBody;
    // Start is called before the first frame update
    void Start()
    {
        _rb2dBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy1")
        {
            Destroy(other.gameObject);
        }

        if (other.tag == "enemy2")
        {
            Destroy(other.gameObject);
        }
    }
}
