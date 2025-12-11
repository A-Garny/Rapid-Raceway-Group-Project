using UnityEngine;

public class PlayerCarController : MonoBehaviour
{
    private Rigidbody playerCarRb;
    public GameObject cpuTrack;
    private float speed = 17f;
    private float turnSpeed = 42f;
    private float horizontalInput;
    private float forwardInput;
    public float jumpPower = 10.0f;
    public float gravityMod;
    public bool isOnRoad = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerCarRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMod;
    }

    // Update is called once per frame
    void Update()
    {
        // lets car jump when spacebar is hit
        if (Input.GetKeyDown(KeyCode.Space) && isOnRoad)
        {
            // Keeps car from jumping mid-air
            isOnRoad = false;
            playerCarRb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Makes it so the player can jump again after hitting road
        if (collision.gameObject.CompareTag("Road"))
        {
            isOnRoad = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Finish"))
        {
            // Makes you win if you cross the finish line
            Debug.Log("You Win");
            // Eliminates the CPU's track when you win
            cpuTrack.gameObject.SetActive(false);
            speed = 0;
        }
    }

}

