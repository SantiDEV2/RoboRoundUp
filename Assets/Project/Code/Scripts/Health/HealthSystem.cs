using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private int MaxHealth;

    [SerializeField] private UnityEvent OnDamageDone;
    
    private int _health;

    public void AddHealth(int addedHealth)
    {
        
    }
}
