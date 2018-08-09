using UnityEngine;

namespace FiringModes
{
    public class FMCharge : MonoBehaviour, IFiringMode
    {
        private bool charging;

        private Weapon weapon;
        private float chargeTime;
        private bool autoRelease;
        private bool earlyRelease;
        private float currentCharge;

        public FMCharge FMChargeInit(Weapon weapon, float chargeTime, bool earlyRelease, bool autoRelease)
        {
            this.weapon = weapon;
            this.chargeTime = chargeTime;
            this.autoRelease = autoRelease;
            this.earlyRelease = earlyRelease;
            return this;
        }

        public void AttemptFire()
        {
            charging = true;
        }

        public void FireReleased()
        {
            if (currentCharge >= chargeTime)
            {
                weapon.Shoot();
            } else if (earlyRelease)
            {
                //Do something to nerf damage
                weapon.Shoot();
            }
            charging = false;
            currentCharge = 0;
        }

        public void Update()
        {
            if (charging == true)
            {
                currentCharge += Time.deltaTime;
                if (currentCharge >= chargeTime)
                {
                    if (autoRelease)
                    {
                        weapon.Shoot();
                        currentCharge = 0;
                    }
                }
            }
        }

    }
}