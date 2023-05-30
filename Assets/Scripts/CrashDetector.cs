using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] AudioClip crashSound;
    [SerializeField] float crashDelay = 1f;
    [SerializeField] ParticleSystem loseEffect;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Ground")
        {
            loseEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSound);
            Invoke("RestartScene", crashDelay);
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(0);
    }
}
