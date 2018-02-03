using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public bool CanMove = true;
    // VR Main Camera
    private Transform CameraNya;
    // Speed to move the player
    public float speed = 3f;
    // CharacterController script
    CharacterController myCC;


    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;


    // Use this for initialization
    void Start () {

        myCC = gameObject.GetComponent<CharacterController>();
        CameraNya = Camera.main.transform;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (CanMove)
        {
            myCC.SimpleMove(speed * CameraNya.TransformDirection(Vector3.forward * Input.GetAxis("Vertical") + Vector3.right * Input.GetAxis("Horizontal")));
        }
    }

    void Update()
    {
        if (CanMove)
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            CameraNya.transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
    }
}
