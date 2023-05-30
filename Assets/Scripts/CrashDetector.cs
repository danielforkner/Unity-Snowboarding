using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float crashDelay = 1f;
    [SerializeField] ParticleSystem loseEffect;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Ground")
        {
            loseEffect.Play();
            Invoke("RestartScene", crashDelay);
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(0);
    }
}
