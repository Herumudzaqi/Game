using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float speed = 5f;
    public float gravity = -9.81f;
    public float jumpHeight = 2f;

    [Header("Joystick")]
    public FixedJoystick joystick;

    [Header("Ground Check")]
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // Ground Check
        isGrounded = Physics.CheckSphere(
            groundCheck.position,
            groundDistance,
            groundMask
        );

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        // =======================
        // JOYSTICK
        // =======================

        // Dibalik karena arah player terbalik
        float x = -joystick.Horizontal;
        float z = -joystick.Vertical;

        Vector3 move = (transform.right * x) + (transform.forward * z);

        controller.Move(move.normalized * speed * Time.deltaTime);

        // =======================
        // GRAVITY
        // =======================

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    // Dipanggil dari tombol Jump
    public void Jump()
    {
        if (isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }
}