using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class testing : MonoBehaviour
{
    public float moveSpeed = 5f;
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

       /* if (current != 0)
        {
            transform.Translate(0, 0, 0);
        }
        */
        if (current == 1)
        {
            transform.Translate(0, 0, 0);
        }

        if (current <= 0.9) 
        {
            transform.Translate(1 * moveSpeed * Time.deltaTime, 0, 0);
        }

        if (current <= -0.85)
        {
            transform.Translate(1.5f * moveSpeed * Time.deltaTime, 0, 0);
            //Debug.Log("ivegonemaximum");
        }

        //transform.Translate(current * moveSpeed, 0, 0);

    }

}
