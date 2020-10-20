using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorEnemy2 : MonoBehaviour
{
    public GameObject prefabEnemy2;

    [SerializeField]
    private int enemy2;
    
    [SerializeField]
    private int time;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GerarEnemy2", enemy2, time);
    }

    // Update is called once per frame
    public void GerarEnemy2()
    {
       // float x = Random.Range(-10.20f,10.20f);
       // float y = Random.Range(-4.20f,-2.28f);

        Vector2 newPosition = new Vector2( 12.1f, -2.89f);

        Instantiate(prefabEnemy2, newPosition, Quaternion.identity);
    }
}
