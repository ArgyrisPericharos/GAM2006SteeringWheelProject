using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReachingPandora : MonoBehaviour
{
    public GameObject Submarine;
    public Image IntrestingPoint;
    public Sprite PandoraPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Works but not the If statement");
        if (other.gameObject == Submarine)
        {
            Debug.Log(IntrestingPoint.sprite);
            IntrestingPoint.sprite = PandoraPoint;
        }
    }
}
