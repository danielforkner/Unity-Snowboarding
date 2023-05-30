using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] AudioClip crashSound;
    [SerializeField] float crashDelay = 1f;
    [SerializeField] ParticleSystem loseEffect;
    bool hasCrashed = false;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Ground" && !hasCrashed)
        {
            FindObjectOfType<PlayerController>().DisableControls();
            loseEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSound);
            Invoke("RestartScene", crashDelay);
            hasCrashed = true;
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(0);
    }
}
