using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BackwardsMoveSub : MonoBehaviour
{

    public InputControl inputControl;
    public InputAction playerControls;

    public float current;
    public float moveSpeed;




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
    // Start is called before the first frame updat

    // Update is called once per frame
    void Update()
    {
        current = playerControls.ReadValue<float>();

        if (current == 1)
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }
        

    }
}
