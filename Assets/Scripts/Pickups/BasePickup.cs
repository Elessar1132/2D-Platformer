using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(SpriteRenderer), typeof(BoxCollider2D))]
public class BasePickup : MonoBehaviour
{
    delegate void PickupItem(GameObject Other);
    PickupItem pickupItem;
	// Use this for initialization
	void Awake ()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
        pickupItem += OnPickup;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Player"))
        {
            // Player picked up this object
            pickupItem(collision.gameObject);
        }
    }

    protected virtual void OnPickup(GameObject Other)
    {
        Debug.Log("OnPickup");
    }
}
