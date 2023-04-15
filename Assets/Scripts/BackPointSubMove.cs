using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BackPointSubMove : MonoBehaviour
{
    public InputControl inputControl1;
    public InputAction playerControls1;

    public InputControl inputControl2;
    public InputAction playerControls2;

    public float current1;
    public float current2;
    // Start is called before the first frame update
    private void OnEnable()
    {
        playerControls1.Enable();
        playerControls2.Enable();
    }

    private void OnDisable()
    {
        playerControls1.Disable();
        playerControls2.Disable();
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        current1 = playerControls1.ReadValue<float>();

        current2 = playerControls2.ReadValue<float>();


        if (current1 == 1)
        {
            transform.Rotate(0, 0, -3 * Time.deltaTime);
        }

        if (current2 == 1)
        {
            transform.Rotate(0, 0, 3 * Time.deltaTime);
        }
    }
}
