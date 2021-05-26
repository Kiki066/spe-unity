using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private float life = 100f;

    //[SerializeField]
    //public Monstre monstre;

    public float Life 
    {
        get
        {
            return life;
        }
        set
        {
            this.life = value;
        }
    }

    private void Start()
    {
        player = GetComponent<GameObject>();
    }

    private void Update()
    {
    }

    

    public void TakeDamage(float damage)
    {
        Life -= damage;
    }
    

}
