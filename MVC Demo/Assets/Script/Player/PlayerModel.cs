using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.Macrobian.Games
{
    [CreateAssetMenu(fileName ="PlayerModel",menuName ="NkObjects/PlayerModel",order =1)]
    public class PlayerModel : ScriptableObject
    {
        #region SerializeFields
        [SerializeField]
        private float speed = 2;
        public float Speed
        {
            get
            {
                return speed;
            }
        }

        [SerializeField]
        private float rotateSpeed = 50;
        public float RotateSpeed
        {
            get
            {
                return rotateSpeed;
            }
        }
        #endregion


    }
}
