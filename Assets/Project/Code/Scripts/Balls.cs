using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public GameObject objetoAmover;
    public Transform t1,t2;
    public float velocidad;
    private Vector3 moverhacia;
    // Start is called before the first frame update
    void Start()
    {
        moverhacia = t2.position;
    }

    // Update is called once per frame
    void Update()
    {
        objetoAmover.transform.position =  Vector3.MoveTowards(objetoAmover.transform.position,moverhacia,velocidad*Time.deltaTime);
        if (objetoAmover.transform.position == t2.position)
        {
            moverhacia = t1.position;
        }
        if (objetoAmover.transform.position == t1.position)
        {
            moverhacia = t2.position;
        }
    }
}
