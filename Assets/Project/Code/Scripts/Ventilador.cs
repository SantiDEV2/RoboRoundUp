using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ventilador : MonoBehaviour
{
    
    public bool esInvertido;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Robot"))
        {
            
            //other.GetComponent<Rigidbody2D>().AddForce(Vector2.up);
            if(esInvertido == false)
            {
                other.GetComponent<Rigidbody2D>().gravityScale=-1;
            }
            else
            {
                other.GetComponent<Rigidbody2D>().gravityScale=4;
            }
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        other.GetComponent<Rigidbody2D>().gravityScale=1;
    }
}
