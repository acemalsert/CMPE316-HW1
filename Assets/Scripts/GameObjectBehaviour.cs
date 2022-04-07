using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectBehaviour : MonoBehaviour
{
    public float moveSpeed;
    public float rotation;

    void Start() {
        moveSpeed = 8f;

    }

    void Update()
    {

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Move
        Vector3 movement = new Vector3(moveX, 0f, moveZ);

        transform.Translate(movement * moveSpeed * Time.deltaTime);

        transform.Rotate(rotation * moveX * Time.deltaTime, 0f, 0f);

    }

}
