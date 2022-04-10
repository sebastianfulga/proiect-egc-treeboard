using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    float inputX, inputZ;
    bool up;
    bool down;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        up = Input.GetKey(KeyCode.Q);
        down = Input.GetKey(KeyCode.E);
        inputZ = Input.GetAxis("Vertical");

        if (inputX != 0)
        {
            rotate();
        }

        if (inputZ != 0)
        {
            move();
        }

        if (up)
        {
            // ca sa revnim la pozitia initiala 
            // transform.position = new Vector3(0, transform.position.y, 0);
            transform.position += transform.up * 50 * Time.deltaTime;
            
            // transform.up
        }

        if (down)
        {
            if (transform.position.y < 10)
            {
                return;
            }

            transform.position -= transform.up * 50 * Time.deltaTime;
        }
    }

    private void move()
    {
        transform.position += transform.forward * inputZ * Time.deltaTime * 50;
    }

    private void rotate()
    {
        transform.Rotate(new Vector3(0f, inputX * Time.deltaTime * 50, 0f));
    }
}
