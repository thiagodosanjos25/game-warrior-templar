using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    public Vector2 _direction;

    public Vector2 _position;

    private Rigidbody2D _rb2dbody;


    // Start is called before the first frame update
    void Start()
    {
        _rb2dbody = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
      
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("knight"))
        {
            LifeController.instance.DecrementarLife(1);
        }
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
