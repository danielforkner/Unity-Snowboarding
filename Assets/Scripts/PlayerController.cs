using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 5f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 15f;
    Rigidbody2D rb2d;
    SurfaceEffector2D ground;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        ground = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        BoostPlayer();
    }

    void BoostPlayer()
    {
        if (Input.GetKey(KeyCode.W))
        {
            ground.speed = boostSpeed;
        } else 
        {
            ground.speed = baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
