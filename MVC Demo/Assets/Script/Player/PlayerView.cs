using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.Macrobian.Games
{
    public class PlayerView : MonoBehaviour
    {
        #region PrivateVariables
        private float h = 0, v = 0;
        private PlayerModel playerModel;
        #endregion

        #region SerializeFields
        [SerializeField]
        private WeaponView weaponView;
        #endregion

        #region Monobehavior
        private void Start()
        {
            playerModel = (PlayerModel)Resources.Load("PlayerModel");
            weaponView.PlayerView = this;
        }

        private void Update()
        {
            v = Input.GetAxis("Vertical") * playerModel.Speed * Time.deltaTime;
            h = Input.GetAxis("Horizontal") * playerModel.RotateSpeed * Time.deltaTime;

            transform.Translate(0, 0, v);
            transform.Rotate(0, h, 0);
        }
        #endregion


        #region Properties
        private GameView gameView;
        public GameView GameView
        {
            set
            {
                gameView = value;
            }
            get
            {
                return gameView;
            }
        }

        public WeaponView WeaponView
        {
            set
            {
                weaponView = value;
            }
            get
            {
                return weaponView;
            }
        }
        #endregion
    }
}
