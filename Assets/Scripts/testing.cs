using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class testing : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 5f;
    public InputAction playerControls;

    [SerializeField]


    // Start is called before the first frame update

    Vector3 moveDirection = Vector3.zero;

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = playerControls.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
