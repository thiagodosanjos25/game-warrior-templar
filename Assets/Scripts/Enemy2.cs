using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    
    public float _speed;
    
    public Vector2 _direction;

    private Rigidbody2D _rb2dbody;

    public Vector2 _position;


    // Start is called before the first frame update
    void Start()
    {
        _rb2dbody = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
     
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rb2dbody.MovePosition(_rb2dbody.position +(_direction*_speed*Time.deltaTime));
    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
