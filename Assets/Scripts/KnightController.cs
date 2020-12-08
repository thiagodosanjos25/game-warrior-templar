using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KnightController : MonoBehaviour
{

    Animator animator;
	float axis;
	Vector2 velocidade;
	bool ladoDireito = true;
	[SerializeField]
	private float speed = 10;
	private GameObject instantiatedObj;



	public GameObject prefabDashedsword1;
	

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
	}

    

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{

			instantiatedObj = (GameObject)Instantiate(prefabDashedsword1, transform.position + new Vector3(2, -0.10f, -0.9f), Quaternion.identity);

			
			Destroy(instantiatedObj, 0.08f);
		
		}
	}

	void Vire(){
		ladoDireito = !ladoDireito;

		Vector2 novoScale = new Vector2 (transform.localScale.x * -1, transform.localScale.y);

		transform.localScale = novoScale;
	}

	
}
