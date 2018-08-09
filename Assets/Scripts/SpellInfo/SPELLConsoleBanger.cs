using System.Collections;
using System.Collections.Generic;
using SpellInfo;
using UnityEngine;

public class SPELLConsoleBanger : MonoBehaviour, ISpellNode {

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
