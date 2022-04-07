using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectBehaviour : MonoBehaviour
{
    public float moveSpeed;
    public float rotationSpeed;

    void Start() {
        moveSpeed = 8f;
        rotationSpeed = 30f;

    }

    void Update()
    {
        PlayerMovement();
        CamMovement();
        

    }
    
    void PlayerMovement()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");
        if (vertical != 0) transform.Translate(0f, 0f, vertical * moveSpeed * Time.deltaTime);
       
        if (horizontal!= 0) transform.Translate(vertical * moveSpeed * Time.deltaTime, 0f, 0f);
    }

    
    void CamMovement()
    {
        float horizatontal = Input.GetAxisRaw("Horizontal");
        transform.Rotate(0f, rotationSpeed * horizatontal * Time.deltaTime, 0f);
    } 

}
