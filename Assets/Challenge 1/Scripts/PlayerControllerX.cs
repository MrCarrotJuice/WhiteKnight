using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move plane on constant speed
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // rotate plane up/down with arrow keys
        // rotate plane up/down with arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
