using UnityEngine;

public class LevelSpriteController : MonoBehaviour
{
    SurfaceEffector2D surface;
    // Start is called before the first frame update
    void Start()
    {
        surface = GetComponent<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            surface.speed = 20;
        } else
        {
            surface.speed = 10;
        }
    }

    
}
