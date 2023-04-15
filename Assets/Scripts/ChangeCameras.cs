using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeCameras : MonoBehaviour
{

    public GameObject cam2;
    public GameObject cam3;



    public InputControl inputControl2;
    public InputAction playerControls2;

    public InputControl inputControl3;
    public InputAction playerControls3;


    public float current2;
    public float current3;


    private void OnEnable()
    {

        playerControls2.Enable();
        playerControls3.Enable();
    }

    private void OnDisable()
    {

        playerControls2.Disable();
        playerControls3.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {

        cam2.SetActive(true);
        cam3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        current2 = playerControls2.ReadValue<float>();
        current3 = playerControls3.ReadValue<float>();



        if (current2 == 1)
        {

            cam2.SetActive(true);
            cam3.SetActive(false);
        }

        if (current3 == 1)
        {

            cam2.SetActive(false);
            cam3.SetActive(true);
        }
    }
}
