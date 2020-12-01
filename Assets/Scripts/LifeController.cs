using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public static LifeController instance;

    [SerializeField]
    private int life;
    public int Life { get { return this.life; } }
    [SerializeField]
    private int maxLife;

    void Start()
    {
        life = maxLife; 
    }        

    void Awake()
    {
        instance = this;
    }

    public void DecrementarLife(int value)
    {
        life -= value;

        if(life <= 0)
        {
            life = 0;
            print("Você está morreu!");
            Destroy(this.gameObject);
        }
        LifeControllerUI.instance.UpdateLifeUI();
    }
}
