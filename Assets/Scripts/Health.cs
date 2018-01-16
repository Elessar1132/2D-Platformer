using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int MaxHealth;
    [SerializeField]
    private int CurrentHealth;

    public delegate void OnHealthChange();
    public OnHealthChange onHealthChange;
	
    // Use this for initialization
	void Start ()
    {
        CurrentHealth = MaxHealth;

        onHealthChange += OnHealthChanged;
        onHealthChange();
    }
	
	public void TakeDamage(int DamageToTake)
    {
        SetCurrentHealth(Mathf.Max(0, CurrentHealth - DamageToTake));
        onHealthChange();

        if (CurrentHealth == 0)
            Debug.Log("CurrentHealth == 0. Dead");
    }

    public void GainHealth(int HealthToGain)
    {
        SetCurrentHealth(Mathf.Min(GetMaxHealth(), CurrentHealth + HealthToGain));
        onHealthChange();
    }

    public void SetMaxHealth(int NewMaxHealth)
    {
        MaxHealth = NewMaxHealth;
    }

    public int GetMaxHealth()
    {
        return MaxHealth;
    }

    public void SetCurrentHealth(int NewCurrentHealth)
    {
        CurrentHealth = NewCurrentHealth;
    }

    public int GetCurrentHealth()
    {
        return CurrentHealth;
    }

    void OnHealthChanged()
    {
        // Play audio?
        // Activate invulnerability?
    }
}
