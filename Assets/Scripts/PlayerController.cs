//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerController : MonoBehaviour
//{
//    [SerializeField] private float speed = 1f;
//    [SerializeField] private float turnSpeed = 10f;
//    public float gravityScale = -9.81f;
//    public Animator animator;
//    private Rigidbody rb;
//    public float groundCheckDistance = 0.1f;

//    void Awake()
//    {
//        rb = GetComponent<Rigidbody>();
//    }

//    private void Start()
//    {
//        animator = GetComponentInChildren<Animator>();
//    }

//    private void Update()
//    {
//        HandleMovementInput();
//    }

//    private void HandleMovementInput()
//    {
//        float horizontal = Input.GetAxis("Horizontal");
//        float vertical = Input.GetAxis("Vertical");

//        Vector3 inputDirection = new Vector3(horizontal, 0f, -vertical).normalized;

//        if (inputDirection.magnitude > 0.1f)
//        {
//            float targetAngle = Mathf.Atan2(inputDirection.z, inputDirection.x) * Mathf.Rad2Deg;
//            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSpeed, 0.1f);
//            transform.rotation = Quaternion.Euler(0f, angle, 0f);

//            float horizontalInput = Input.GetAxisRaw("Horizontal");
//            float verticalInput = Input.GetAxisRaw("Vertical");

//            rb.velocity = new Vector3(horizontalInput * speed, rb.velocity.y, -vertical * speed);

//            rb.velocity += Vector3.up * gravityScale * Time.deltaTime;

//            animator.SetBool("IsMoving", true);
//        }
//        else
//        {
//            animator.SetBool("IsMoving", false);
//        }
//    }
//}

//ESTE DE ABAJO ES EL BUENO QUE SI FUNCIONA

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public CharacterController cc;
    public float speed = 5f;

    public float Gravity = -9.81f;
    public Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask floorMask;
    bool isGrounded;
    public Animator animator;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public Transform cam;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }
    void Update()
    {
        //Movimiento
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

            transform.rotation = Quaternion.Euler(0, angle, 0);

            Vector3 moveDir = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
            cc.Move(moveDir.normalized * speed * Time.deltaTime);

            animator.SetBool("IsMoving", true);
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }

        //Detección de suelo
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, floorMask);
        //Gravedad
        velocity.y += Gravity * Time.deltaTime;
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -1.86f;
        }
        cc.Move(velocity * Time.deltaTime);
        //Salto
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(3 * -2 * Gravity);
        }

    }

}
