using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoordinatesTracking : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI xcoordinates;
    public TextMeshProUGUI zcoordinates;
    public TextMeshProUGUI ycoordinates;


    public GameObject Cockpit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        xcoordinates.text = "x" + Cockpit.transform.position.x.ToString();
        zcoordinates.text = "z" + Cockpit.transform.position.z.ToString();
        ycoordinates.text = "y" + Cockpit.transform.position.y.ToString();




        // xcoordinates.text = Cockpit.transform.position.x;
    }
}
