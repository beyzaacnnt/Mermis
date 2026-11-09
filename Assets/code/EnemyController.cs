using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class EnemyController : MyCharacterController
{
    [SerializeField] private PlayerController player;

    private void FixedUpdate()
    {
        var delta = -transform.position + player.transform.position;
        delta.y = 0;
        var direction = delta.normalized;
        Move(direction);
    
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag($"Bullet"))
        {
            gameObject.SetActive(false);
            other.gameObject.SetActive(false);
        }
    }
  //  private void OnCollisionEnter(Collision collision)
  //  {
   //     if (collision.transform.CompareTag($"Bullet"))
    //    {
    //        gameObject.SetActive(false);
   //         collision.gameObject.SetActive(false);
   //    }
   // }
}


