using UnityEngine;

namespace FiringModes
{
    public class FMSingleShot : MonoBehaviour, IFiringMode
    {
        private Weapon weapon;
        private float shotDelay;
        private float lastShot;

        public FMSingleShot FMSingleShotInit(Weapon weapon, float shotDelay)
        {
            this.weapon = weapon;
            this.shotDelay = shotDelay;
            lastShot = 0;
            return this;
        }
        
        public void AttemptFire()
        {
            if (Time.time - shotDelay > lastShot)
            {    
                weapon.Shoot();
                lastShot = Time.time;
            }
        }
        public void FireReleased(){}
        
    }
}