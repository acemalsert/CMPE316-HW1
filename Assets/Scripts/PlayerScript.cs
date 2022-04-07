using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    
    Rigidbody rigidBody;
    float jump;
    bool isInTheGround;
    float InitialTime;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("Space") && isInTheGround)
        {
            rigidBody.AddForce(Vector3.up * jump, ForceMode.Impulse);
            isInTheGround = false;
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Plane"))
        {
            isInTheGround = true;
        }
    }
}
