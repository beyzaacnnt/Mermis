using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
   // [SerializeField] ScreentouchController input;
    [SerializeField] private Rigidbody myRigidbody;
    [Range(200,2000)][SerializeField] private float moveSpeed;

    protected void Move(Vector3 direction)
    {
        myRigidbody.velocity = direction * moveSpeed * Time.deltaTime;
    }

    //private void FixedUpdate()
   //  {
   //     var direction = new Vector3(input.Direction.x, y: 0, z: input.Direction.y);
    // Move(direction);
   // }
}

