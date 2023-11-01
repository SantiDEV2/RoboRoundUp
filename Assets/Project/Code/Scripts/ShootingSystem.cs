using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
    [SerializeField] Trajectory trajectory;

    [SerializeField] private float range;

    [SerializeField] private float maxSpeed;

    private Rigidbody2D _rb;

    private Vector3 _distance;

    private Vector3 _position;

    private GameObject actualTarget;

    [SerializeField] private GameObject gunVisual;

    private bool _showGun= false;

    [SerializeField] private float minumRange;
    [SerializeField] private LayerMask layer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseControll();
        ShowGun();
    }

    void MouseControll()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetTarget();
        }

        if (Input.GetMouseButton(0))
        {
            _showGun = true;
                           
            CalculateDistance();
        }

        if (Input.GetMouseButtonUp(0))
        {
            _showGun = false;

            ApplyForce();
            trajectory.Hide();
            actualTarget = null;
        }
    }

    private void ShowGun()
    {
       
        if (_showGun && actualTarget!=null && _distance.magnitude > minumRange)
        {
            gunVisual.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255, 255);
            
            Vector3 dir = _distance + actualTarget.transform.position;

            gunVisual.transform.position = new Vector3(dir.x, dir.y, 0);


            Vector2 direction = actualTarget.transform.position - gunVisual.transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle - 90 , Vector3.forward);

            gunVisual.transform.rotation = rotation;
        }
        else
        {
            trajectory.Hide();
            gunVisual.GetComponentInChildren<SpriteRenderer>().color = new Color(255, 255, 255, 0);
        }
    }
    private void CalculateDistance()
    {
        if (actualTarget == null) return;
        trajectory.Show();
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        _distance = mousePos - actualTarget.transform.position;
        _distance.z = 0;

        if (_distance.magnitude > range)
        {
            _distance = _distance.normalized * range;
        }
        trajectory.UpdateDots(actualTarget.transform.position, -_distance.normalized * maxSpeed * _distance.magnitude / range);
    }

    private void ApplyForce()
    {
        if (actualTarget == null||_distance.magnitude < minumRange) return;
        Rigidbody2D rb = actualTarget.GetComponent<Rigidbody2D>();

        rb.bodyType = RigidbodyType2D.Dynamic;
       
        rb.velocity = -_distance.normalized * maxSpeed * _distance.magnitude / range;
        actualTarget.GetComponentInParent<HealthSystem>().TakeDamage();
        
    }

    private void GetTarget()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero,layer);
        if (hit.collider != null&&hit.collider.CompareTag("Robot"))
        {
            Debug.Log(hit.collider.gameObject.name);

            actualTarget = hit.collider.gameObject;
        }
    }
}
