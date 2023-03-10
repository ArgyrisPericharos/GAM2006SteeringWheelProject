using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AxisMovementTest : MonoBehaviour
{
    public InputAction playerControl;
    // Start is called before the first frame update
    private void OnEnable()
    {
        playerControl.Enable();
    }

    private void OnDisable()
    {
        playerControl.Disable();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        

        
    }
}
