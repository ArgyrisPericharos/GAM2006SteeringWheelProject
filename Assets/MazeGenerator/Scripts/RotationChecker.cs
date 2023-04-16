using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RotationChecker : MonoBehaviour
{
    // Start is called before the first frame update

    public Quaternion values;
    public GameObject Cockpit;
    public bool On;
    public TextMeshProUGUI Rcoordinates;
    
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
            Rcoordinates.text = "R" + values.eulerAngles.y.ToString();
        }


    }
}
