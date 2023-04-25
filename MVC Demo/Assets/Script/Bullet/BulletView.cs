using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.Macrobian.Games
{
    public class BulletView : MonoBehaviour
    {
        #region PrivateVariable
        private BulletModel bulletModel;
        #endregion

        #region Monobehaviour
        void Start()
        {
            bulletModel = (BulletModel)Resources.Load("BulletModel");
            Destroy(this.gameObject, bulletModel.DestroyTime);
        }

        void Update()
        {
            if (trPlayer)
                transform.Translate(trPlayer.up * Time.deltaTime * bulletModel.Speed);
        }
        #endregion


        #region Properties
        private Transform trPlayer;
        public Transform TrPlayer
        {
            get
            {
                return trPlayer;
            }
            set
            {
                trPlayer = value;
            }
        }
        #endregion
    }
}
