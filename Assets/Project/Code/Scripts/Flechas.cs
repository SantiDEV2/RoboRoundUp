using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Flechas : MonoBehaviour
{
    public GameObject arrows;
    
    public float fuerza;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Disparar",0.5f,1.5f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Disparar()
    {
        GameObject actual = Instantiate(arrows,gameObject.transform.position,quaternion.identity);
        actual.GetComponent<Rigidbody2D>().AddForce(Vector2.up*fuerza*1000);
        Destroy(actual,0.4f);
        
    }
}
