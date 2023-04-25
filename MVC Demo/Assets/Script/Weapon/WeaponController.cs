using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.Macrobian.Games
{
    public class WeaponController
    {
        private WeaponModel weaponModel;

        #region PublicMethods
        public WeaponController(WeaponModel weaponModel)
        {
            this.weaponModel = weaponModel;
        }

        public bool BulletShoot(ref int bulletCounter)
        {
            bulletCounter++;

            if (weaponModel.MaxBullets <= bulletCounter)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
