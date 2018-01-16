using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : BasePickup
{
    public int HealthGainAmount;

    protected override void OnPickup(GameObject Other)
    {
        base.OnPickup(Other);

        Health HealthComp = Other.GetComponent<Health>();
        if (HealthComp)
        {
            //Debug.Log("Gain Health: " + HealthGainAmount);
            HealthComp.GainHealth(HealthGainAmount);
        }
    }
}
