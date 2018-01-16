using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int MaxHealth;
    [SerializeField]
    private int CurrentHealth;
	
    // Use this for initialization
	void Start ()
    {
        CurrentHealth = MaxHealth;
    }
	
	public void TakeDamage(int DamageToTake)
    {
        Mathf.Max(0, CurrentHealth - DamageToTake);

        // TODO(Chris): Activate invulnerability?

        if (CurrentHealth == 0)
            Debug.Log("CurrentHealth == 0. Dead");
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
}
