using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D _rb2dBody;

    void Start()
    {
        _rb2dBody = GetComponent<Rigidbody2D>();
    }

       void OnTriggerEnter2D(Collider2D other)
    {
        //print("Trigger Enter");
        if (other.tag == "knight"){
           Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
