using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float speed = 3f;
    private float horizontalMovement;
    public float maxX = 7.5f;
    private void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");                            
        if((horizontalMovement > 0 && transform.position.x < maxX) ||  ( horizontalMovement < 0 && transform.position.x > -maxX))
        {
            transform.position += Vector3.right *horizontalMovement * speed * Time.deltaTime;
        }
    }

}
