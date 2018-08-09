using System.Collections;
using System.Collections.Generic;
using SpellCasts;
using UnityEngine;

public class SPELLConsoleBanger : MonoBehaviour, ISpellCast {

    private Weapon weapon;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Cast()
	{
		Debug.Log("DEFAULT BANG!");
	}
}
