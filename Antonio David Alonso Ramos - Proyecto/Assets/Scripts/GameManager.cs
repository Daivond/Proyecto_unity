using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float rd = 1f;

    public GameObject complete;

    public void CompleteLevel ()  
    {
        complete.SetActive(true);
    }

    public void EndGame () 
    {
        if (gameHasEnded == false) 
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", rd);
        }
    }

    void Restart () 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
