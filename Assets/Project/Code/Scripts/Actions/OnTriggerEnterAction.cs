using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEnterAction : MonoBehaviour
{
    [SerializeField] private LayerMask _collisionMask;

    [SerializeField] private UnityEvent OnTriggerAction;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        var otherLayer = other.gameObject.layer;
        //CHECK IS "_collisionMask" is in layer "otherLayer"
        var isInLayerMask = (_collisionMask & (1<<otherLayer)) != 0;
        Debug.Log("isInLayer Mask: "+isInLayerMask);
        if (!isInLayerMask) return;
        OnTriggerAction?.Invoke();
    }
}
