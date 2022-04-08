using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    
    public Rigidbody rigidBody;
    public bool isInTheGround = true;
    public float InitialTime;
    // Start is called before the first frame update
    void Start()
    {
  
        rigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isInTheGround)
        {
            rigidBody.AddForce(new Vector3(0,5,0), ForceMode.Impulse);
            isInTheGround = false;
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isInTheGround = true;
        }
    }
}
