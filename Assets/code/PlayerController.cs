using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MyCharacterController
{
    [SerializeField] private ScreentouchController input;
    [SerializeField] private ShootController shootController;
  

    private void FixedUpdate()
    {
        var direction = new Vector3(input.Direction.x, y: 0, z: input.Direction.y);
        Move(direction);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag($"Enemy"))
        {
            Dead();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag($"Enemy"))
        {
            var direction = other.transform.position - transform.position;
            direction.y = 0;
            direction = direction.normalized;
            shootController.Shoot(direction, transform.position);
        }

    }
    private void Dead()
    {
        Debug.Log("Dead");
        Time.timeScale = 0;
    }
}
