using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SubmarineSteering : MonoBehaviour
{
   
    public InputControl inputControl;
    public InputAction playerControls;

    public float current;


    // Start is called before the first frame updat

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

        current = playerControls.ReadValue<float>();

        transform.Rotate(0, current * 10 * Time.deltaTime, 0);

    }


}

