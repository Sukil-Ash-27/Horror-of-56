using UnityEngine;

public class PlyrMovement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float speed = 3f;
    [SerializeField] private float runSpeedMultiplier = 1.5f;
    private Animator anim;
    private bool isRunning = false;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized;
        isRunning = Input.GetKey(KeyCode.LeftShift);
      //  if (movement.magnitude > 0.01f)
       // {
            float currentSpeed = isRunning ? speed * runSpeedMultiplier : speed;
            body.linearVelocity = movement * currentSpeed;
      //  }
      //  else
       // {
        //    body.linearVelocity = Vector2.zero; // Instantly stop movement when no input
       // }

        // Flip character direction
        if (horizontalInput > 0.01f)
        {
            transform.localScale = new Vector3(0.22754f, 0.2071069f, 0.22754f);
        }
        else if (horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-0.22754f, 0.2071069f, 0.22754f);
        }

        // Update animation
        anim.SetBool("Walk", movement.magnitude > 0 && !isRunning);
        anim.SetBool("Run", movement.magnitude > 0 && isRunning);
    }
}
