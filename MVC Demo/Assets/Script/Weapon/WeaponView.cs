using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.Macrobian.Games
{
    public class WeaponView : MonoBehaviour
    {
        #region PrivateVariables
        private WeaponModel weaponModel;
        private WeaponController weaponController;
        #endregion


        #region SerializeFields
        [SerializeField]
        private GameObject bulletPrefeb;
        #endregion


        #region MonoBehaviour
        private void Start()
        {
            weaponModel = (WeaponModel)Resources.Load("WeaponModel");
            weaponController = new WeaponController(weaponModel);
        }
        #endregion


        #region PublicMethods
        public void Shoot()
        {
            GameObject bulletClone = Instantiate(bulletPrefeb, playerView.transform.position
            , Quaternion.Euler(90, playerView.transform.eulerAngles.y, 0));
            bulletClone.GetComponent<BulletView>().TrPlayer = playerView.transform;

            isBulletAvailable = weaponController.BulletShoot(ref bulletCounter);
            playerView.GameView.ShowBulletCounter(bulletCounter, weaponModel.MaxBullets);
            playerView.GameView.CheckBullets(isBulletAvailable, weaponModel.ReloadTime);
        }

        public void Reset()
        {
            bulletCounter = 0;
            isBulletAvailable = true;
            playerView.GameView.ShowBulletCounter(bulletCounter, weaponModel.MaxBullets);
        }
        #endregion


        #region Properties
        private PlayerView playerView;
        public PlayerView PlayerView
        {
            get
            {
                return playerView;
            }
            set
            {
                playerView = value;
            }
        }

        private bool isBulletAvailable = true;
        public bool IsBulletAvailable
        {
            set
            {
                isBulletAvailable = value;
            }
            get
            {
                return isBulletAvailable;
            }
        }


        private int bulletCounter = 0;
        public int BulletCounter
        {
            set
            {
                bulletCounter = value;
            }
            get
            {
                return bulletCounter;
            }
        }
        #endregion
    }
}
