using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{


    [SerializeField]        //permet de faire apparaitre speed dans Unity
    private float speed = 3f;

    [SerializeField]
    private float mouseSensitivityX = 3f;

    [SerializeField]
    private float mouseSensitivityY = 3f;

    private PlayerMotor motor;

    private void Start()
    {
        motor = GetComponent<PlayerMotor>();    //Stocke le script PlayerMotor dans Motor
    }

    // Update is called once per frame
    void Update()
    {
        // Calculer la vitesse du mouvement de notre joueur
        float xMov = Input.GetAxis("Horizontal");  // Input.GetAxisRaw retourne les valeurs 1 ou -1
        float zMov = Input.GetAxis("Vertical");

        Vector3 moveHorizontal = transform.right * xMov;    //Prend le champs right du composant "transform" de Unity.
        Vector3 moveVertical = transform.forward * zMov;

        Vector3 velocity = (moveHorizontal + moveVertical) * speed;

        motor.Move(velocity);
    }
}
