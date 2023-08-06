using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipFlop : MonoBehaviour
{
    private bool control;
    public GameObject flashlight;

    // Start is called before the first frame update
    void Start()
    {
        control = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if(control)
            {
                flashlight.GetComponent<Light>().enabled= false;
                control = false;
            }
            else
            {
                flashlight.GetComponent<Light>().enabled = true;
                control = true;
            }
        }
    }
}
