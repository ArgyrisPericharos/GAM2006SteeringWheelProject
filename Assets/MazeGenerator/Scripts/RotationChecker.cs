using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationChecker : MonoBehaviour
{
    // Start is called before the first frame update

    public Quaternion values;
    public GameObject Cockpit;
    public bool On;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        values = Cockpit.transform.rotation;

        if (On)
        {
            this.transform.rotation = Quaternion.Euler(values.eulerAngles);
        }


    }
}
