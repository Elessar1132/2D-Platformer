using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePickup : MonoBehaviour
{
    delegate void PickupItem();
    PickupItem pickupItem;
	// Use this for initialization
	void Awake ()
    {
        pickupItem += OnPickup;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Player"))
        {
            // Player picked up this object
            pickupItem();
        }
    }

    protected virtual void OnPickup()
    {
        Debug.Log("OnPickup");
    }
}
