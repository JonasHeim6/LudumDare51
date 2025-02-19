using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGegner : MonoBehaviour
{
    public float speed = 20f;
	public int damage = 40;
	public Rigidbody2D rb;
	//public GameObject impactEffect;

	// Use this for initialization
	void Start () {
		rb.velocity = transform.right * speed;
	}

	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		Health enemy = hitInfo.GetComponent<Health>();
        PlayerMovement test = hitInfo.GetComponent<PlayerMovement>();
		if (enemy != null && test != null)
		{
			enemy.TakeDamage(damage);
		}

		//Instantiate(impactEffect, transform.position, transform.rotation);

		Destroy(gameObject);
	}
}
