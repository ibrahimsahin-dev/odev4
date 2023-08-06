using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class UstTakim : MonoBehaviour
{
    private float xRotation = 0.0f;
    public float mouseSensivity = 100.0f;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX=Input.GetAxis("Mouse X")*Time.deltaTime*mouseSensivity;
        float MouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensivity;
        xRotation -= MouseY;
        xRotation=Mathf.Clamp(xRotation, 0.0f, 30.0f);
        transform.localRotation=Quaternion.Euler(xRotation, 0.0f, 0.0f);
        player.transform.Rotate(Vector3.up*MouseX);
    }
}
