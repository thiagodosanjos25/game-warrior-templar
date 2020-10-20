using UnityEngine;
using System.Collections;

public class KnightController : MonoBehaviour
{

    Animator animator;
	float axis;
	Vector2 velocidade;
	bool ladoDireito = true;
	[SerializeField]
    private int life = 500; 
	[SerializeField]
	private float speed = 10;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}

	void FixedUpdate()
	{
		axis = Input.GetAxis ("Horizontal");

		if (axis > 0 && !ladoDireito)
			Vire ();
		if (axis < 0 && ladoDireito)
			Vire ();
		
		velocidade = new Vector2 (axis * speed, GetComponent<Rigidbody2D>().velocity.y);

		GetComponent<Rigidbody2D>().velocity = velocidade;

        if(life<=0){
            print("Você está morreu!");
            Destroy(this.gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {        
        if (other.tag == "enemy1"){
            life = life -200;            
        }

        if (other.tag == "enemy2"){
            life = life -100;            
        }
    }

	// Update is called once per frame
	void Update () {

	}

	void Vire(){
		ladoDireito = !ladoDireito;

		Vector2 novoScale = new Vector2 (transform.localScale.x * -1, transform.localScale.y);

		transform.localScale = novoScale;
	}
}
