using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePickup : BasePickup
{
    public int DamageToTake;

    protected override void OnPickup(GameObject Other)
    {
        base.OnPickup(Other);

        Health OtherHealth = Other.GetComponent<Health>();
        if (OtherHealth)
        {
            //Debug.Log("Take Damage: " + DamageToTake);
            OtherHealth.TakeDamage(DamageToTake);
        }
    }
}
