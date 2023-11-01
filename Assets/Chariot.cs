using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chariot : MonoBehaviour
{
    [SerializeField] private Puntuacion punt;
    private HashSet<Transform> robotsMuertos = new();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Robot")) return;

        var robotRoot = collision.transform.root;

        if (robotsMuertos.Contains(robotRoot)) return;

        robotsMuertos.Add(robotRoot);

        robotRoot.gameObject.SetActive(false);
        if (punt != null)
        {
            punt.AddPoint();
        }
        
    }
}
