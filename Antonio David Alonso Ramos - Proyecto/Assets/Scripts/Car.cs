using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float MovementSpeed = 10;
    private Vector3 MovementDirection;
    public Rigidbody Rb;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovementDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            MovementDirection += transform.forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            MovementDirection -= transform.right;
        }

        if (Input.GetKey(KeyCode.D))
        {
            MovementDirection += transform.right;
        }

        // Se ha quitado dado que daba problemas con el lanzamiento de la última escena
        /*if (Rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }*/

        MovementDirection = MovementDirection.normalized;

        

    }

    private void FixedUpdate()
    {
        Rb.AddForce(MovementDirection * MovementSpeed * Time.fixedDeltaTime);
    }

}
