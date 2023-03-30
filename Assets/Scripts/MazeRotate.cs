using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MazeRotate : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    public InputControl inputControl;
    public InputAction playerControls;
    public float current;

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        current = playerControls.ReadValue<float>();

        transform.Rotate(0, current * moveSpeed, 0);
    }
}
