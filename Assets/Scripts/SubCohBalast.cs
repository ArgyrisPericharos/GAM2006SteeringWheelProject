using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SubCohBalast : MonoBehaviour
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
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }

        if (current2 == 1)
        {
            transform.Translate(0, 7 * Time.deltaTime, 0);
        }
    }
}
