using System;
using System.Collections;
using System.Collections.Generic;
using AmmoTypes;
using UnityEngine;

public class AProjectile : MonoBehaviour, IAmmoType {

	private Sprite sprite;
	private float projectileSpeed;
	private float timeout;

	public AProjectile AProjectileInit(String spritepath, float projectileSpeed, float timeout)
	{
		this.sprite = Resources.Load<Sprite>(spritepath);
		this.projectileSpeed = projectileSpeed;
		this.timeout = timeout;
		return this;
	}

	public void Shoot()
	{
		GameObject proj = Instantiate<GameObject>(Resources.Load<GameObject>("Projectiles/PProjectile"),gameObject.transform);
		Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition)- transform.position;
		
		proj.GetComponent<SpriteRenderer>().sprite = sprite;
		proj.GetComponent<Rigidbody2D>().velocity = projectileSpeed * direction.normalized;
		proj.transform.Rotate(0,0,Vector2.SignedAngle(Vector2.right, direction));
		
		Destroy(proj,timeout);

	}
}
