using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }
}
