using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstre : MonoBehaviour
{
    [SerializeField]
    private float damage = 50f;

    [SerializeField]
    public Player player;

    public float Damage
    {
        get
        {
            return damage;
        }
        set
        {
            this.damage = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "leonard")
        {
            player.TakeDamage(Damage);
            if(player.Life <= 0)
            {
                player.gameObject.SetActive(false);
            }
        }
    }



}
