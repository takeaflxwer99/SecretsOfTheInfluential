using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float turnSpeed = 10f;
    public Animator animator;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        HandleMovementInput();
    }

    private void HandleMovementInput()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Corrige la direcci�n del input
        Vector3 inputDirection = new Vector3(horizontal, 0f, -vertical).normalized;

        if (inputDirection.magnitude > 0.1f)
        {
            // Corrige la rotaci�n hacia la direcci�n de movimiento
            float targetAngle = Mathf.Atan2(inputDirection.z, inputDirection.x) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSpeed, 0.1f);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            // Mueve al jugador en la direcci�n de movimiento
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            // Activa la animaci�n de movimiento
            animator.SetBool("IsMoving", true);
        }
        else
        {
            // Desactiva la animaci�n de movimiento cuando no se est� moviendo
            animator.SetBool("IsMoving", false);
        }
    }
}
