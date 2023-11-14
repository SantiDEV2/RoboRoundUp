using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{
    private bool yaChoco;
     private void OnCollisionEnter2D(Collision2D collision)
     {
        if (yaChoco)
        {
            return;
        }
        if (collision.gameObject.CompareTag("Robot"))
        {
            yaChoco = true;
           collision.transform.root.GetComponent<HealthSystem>().AddHealth(-1);
           Destroy(gameObject);

        }
     }
}
