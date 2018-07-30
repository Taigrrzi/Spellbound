using System.Collections;
using System.Collections.Generic;
using AmmoTypes;
using UnityEngine;

public class AConsoleBanger : MonoBehaviour, IAmmoType {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Shoot()
	{
		Debug.Log("BANG!");
	}
}
