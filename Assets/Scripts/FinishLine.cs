using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float finishDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.tag == "Player")
        {
            finishEffect.Play();
            Invoke("RestartScene", finishDelay);
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(0);
    }
}
