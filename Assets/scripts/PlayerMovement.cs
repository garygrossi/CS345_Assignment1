using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

public float speed;
public float jumpDistance;

private Rigidbody _myRigidbody;

// Use this for initialization
void Start () {
_myRigidbody = GetComponent<Rigidbody>();
}

// Update is called once per frame
void Update () {
if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W))
transform.position += transform.forward * Time.deltaTime * speed;
if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S))
transform.position -= transform.forward * Time.deltaTime * speed;
if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A))
transform.Rotate(0, -1.0f, 0);
if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D))
transform.Rotate(0, 1.0f, 0);
}
}
