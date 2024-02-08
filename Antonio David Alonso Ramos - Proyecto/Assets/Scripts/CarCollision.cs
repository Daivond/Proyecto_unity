using UnityEngine;

public class CarCollision : MonoBehaviour
{
    public Car movement;


    //When something collides the object
    void OnCollisionEnter(Collision collisionInfo )
    {
        if (collisionInfo.collider.name.StartsWith("Obstacle") )
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
