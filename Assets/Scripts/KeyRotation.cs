using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a") )
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z = 1f * Time.deltaTime; ;
            transform.rotation = Quaternion.Euler(rotationVector);
        }

        if (Input.GetKey("d"))
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z = -1f * Time.deltaTime;
            transform.rotation = Quaternion.Euler(rotationVector);
        }

    }
}
