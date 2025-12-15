using UnityEngine;

public class ComputerCarController : MonoBehaviour
{
    public float cpuSpeed = 14.0f;
    public bool hasLost = false;
    public GameObject playerTrack;
    private GameManager gameManager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * cpuSpeed);

        // stops the cpu car if you've already won
        if (hasLost)
        {
            cpuSpeed = 0.0f;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            //Makes you lose if the CPU crosses finish first
            Debug.Log("You Lose");
            // Removes your track if you lose
            playerTrack.gameObject.SetActive(false);
            cpuSpeed = 0;
            // Displays "Game Over" and lets you restart if you lose
            gameManager.GameOver();
        }
    }

}
