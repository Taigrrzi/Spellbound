using System.Collections;
using System.Collections.Generic;
using SpellInfo;
using FiringModes;
using UnityEngine;
using UnityEngine.Experimental.UIElements;


public class Weapon : MonoBehaviour
{

	private int currentAmmo;

	public int maxAmmo;
    public bool automatic;

	private ISpellNode spellCast;
	private IFiringMode firingMode;

	public void Shoot()
	{
        spellCast.Cast();
	}

	public void WeaponPressed()
	{
        if (automatic == false)
        {
            firingMode.AttemptFire();
        }
	}

	public void WeaponDown()
	{
        if (automatic == true)
        {
            firingMode.AttemptFire();
        }
    }

	public void WeaponReleased()
	{
		firingMode.FireReleased();
	}

	void Start()
	{
        //firingMode = gameObject.AddComponent<FMCharge>().FMChargeInit(this, 1f, false, automatic);
        //firingMode = gameObject.AddComponent<FMSingleShot>().FMSingleShotInit(this, 0.2f);
        firingMode = gameObject.AddComponent<FMBurstFire>().FMBurstFireInit(this, 0.5f, 3, 0.1f);
        spellCast = gameObject.AddComponent<SCProjectile>().Init("Projectiles/bullet",10f,10f);
	}

	void Update()
	{
		if (Input.GetMouseButtonDown((int) MouseButton.LeftMouse))
		{
			WeaponPressed();
		}
		if (Input.GetMouseButton((int) MouseButton.LeftMouse))
		{
			WeaponDown();
		}
		if (Input.GetMouseButtonUp((int) MouseButton.LeftMouse))
		{
			WeaponReleased();
		}
	}
}
