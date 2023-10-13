using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{

    [SerializeField] private float Range;

    [SerializeField] private float maxSpeed;

    private Rigidbody2D rb;

    private Vector2 distance;

    private Vector3 position;

    private GameObject actualTarget;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseControll();   
    }

    void MouseControll()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                actualTarget = hit.collider.gameObject;
            }
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            distance = mousePos - actualTarget.transform.position;
            
            if(distance.magnitude > Range)
            {
                distance = distance.normalized * Range;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            Rigidbody2D rb = actualTarget.GetComponent<Rigidbody2D>();

            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.velocity = -distance.normalized * maxSpeed * distance.magnitude / Range;
        }
    }
}
