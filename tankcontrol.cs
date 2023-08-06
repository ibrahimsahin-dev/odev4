using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class tankcontrol : MonoBehaviour
{
    public float Speedcontrol = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 yönx = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.position += yönx*Time.deltaTime*Speedcontrol;
    }
}
