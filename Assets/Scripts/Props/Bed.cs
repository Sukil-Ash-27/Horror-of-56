using UnityEngine;

public class Bed : MonoBehaviour
{
    [SerializeField] private GameObject E; // UI prompt
    [SerializeField] private GameObject body; // Player GameObject
    [SerializeField] private GameObject head; // Optional: Player head
    private bool isNear = false;
    private bool sleeping = true; // Start in sleeping state
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        // Initialize the player in a sleeping state
        anim.SetBool("Sleep", true); // Trigger sleeping animation
        body.GetComponent<SpriteRenderer>().enabled = false; // Hide player's sprite
        body.GetComponent<PlyrMovement>().enabled = false; // Disable movement (replace with your script)
        head.GetComponent<SpriteRenderer>().enabled=false;
        E.SetActive(true);
      //  E.SetActive(false); // Ensure the "E" prompt is hidden

        // Make sure the bed recognizes the player is nearby at the start
        isNear = true; // Force interaction available
    }

    private void Update()
    {
        if (isNear && Input.GetKeyDown(KeyCode.E)) // Use GetKeyDown for single keypress
        {
            ToggleSleep();
        }
    }

    private void ToggleSleep()
    {
        sleeping = !sleeping; // Toggle sleeping state
        anim.SetBool("Sleep", sleeping);

        if (sleeping)
        {
            body.GetComponent<SpriteRenderer>().enabled = false; // Hide the player's sprite
            body.GetComponent<PlyrMovement>().enabled = false; // Disable movement
            head.GetComponent<SpriteRenderer>().enabled = false;
           // E.SetActive(false); // Hide the UI prompt while sleeping
            
        }
        else
        {
            body.GetComponent<SpriteRenderer>().enabled = true; // Show the player's sprite
            body.GetComponent<PlyrMovement>().enabled = true; // Enable movement
            head.GetComponent<SpriteRenderer>().enabled = true;
            E.SetActive(true); // Show the UI prompt when awake
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !sleeping)
        {
            E.SetActive(true);
            isNear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !sleeping)
        {
            E.SetActive(false);
            isNear = false;
        }
    }
}


