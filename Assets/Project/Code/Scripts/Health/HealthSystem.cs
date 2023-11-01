using UnityEngine;
using UnityEngine.Events;
using RacTools.Variables;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private VariableReference<int> MaxHealth;

    [SerializeField] private UnityEvent OnDamageDone;
    [SerializeField] private UnityEvent OnDead;

    public int Health => _health;
    private int _health;
    private void Start()
    {
        _health = MaxHealth.Value;
    }

    public void AddHealth(int addedHealth)
    {
        var newHealth = _health + addedHealth;
        if(newHealth < _health)
            OnDamageDone?.Invoke();
        
        _health = Mathf.Clamp(newHealth, 0, MaxHealth.Value);
        //_health = newHealth;
        if(_health <= 0)
            OnDead?.Invoke();
    }
    
    [ContextMenu("Take Damage")]
    public void TakeDamage()
    {
        Debug.Log("Takes damage");
        if (!Application.IsPlaying(this)) return;
        AddHealth(-1);
    }
}
