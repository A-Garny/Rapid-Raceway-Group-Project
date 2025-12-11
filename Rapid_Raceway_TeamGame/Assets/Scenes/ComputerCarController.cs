using UnityEngine;

public class ComputerCarController : MonoBehaviour
{
    public float cpuSpeed = 14.0f;
    public GameObject playerTrack;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * cpuSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {

            Debug.Log("You Lose");
            playerTrack.gameObject.SetActive(false);
            cpuSpeed = 0;
        }
    }

}
