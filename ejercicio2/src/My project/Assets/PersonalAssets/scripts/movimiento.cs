using UnityEngine;
using UnityEngine.InputSystem;

public class movimiento : MonoBehaviour
{
    public float speed = 5f;
    public float gravity = -20f;
    public float jumpheight = 2f;
    public float velocidadRotacion = 100f;

    private CharacterController controller;
    private Vector2 moveInput;
    private float verticalVelocity;
    private bool jumpPressed;

    private Animator animator;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        bool isGrounded = controller.isGrounded;

        if (isGrounded && verticalVelocity < 0)
        {
            verticalVelocity = -2f; // Pequeña fuerza hacia abajo para mantener al personaje en el suelo
        }

        if (isGrounded && jumpPressed)
        {
            verticalVelocity = Mathf.Sqrt(jumpheight * -2f * gravity);
            jumpPressed = false; // Reinicia el estado de salto
        }

        verticalVelocity += gravity * Time.deltaTime;

        Vector3 move = new Vector3(moveInput.x, verticalVelocity, moveInput.y);

        move.y = verticalVelocity / speed;
        controller.Move(move * speed * Time.deltaTime);

        if (animator != null)
        {
            // Verifica si el jugador está presionando las teclas WASD (magnitud mayor a 0)
            bool estaMoviendose = moveInput.sqrMagnitude > 0;

            // Envía los datos al Animator Controller
            animator.SetBool("estaCaminando", estaMoviendose);
            animator.SetBool("enElSuelo", isGrounded);
        }


    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            jumpPressed = true;
        }
    }
}
