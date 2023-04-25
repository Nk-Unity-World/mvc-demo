using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.Macrobian.Games
{
    [CreateAssetMenu(fileName ="BulletModel",menuName ="NkObjects/BulletModel",order =1)]
    public class BulletModel : ScriptableObject
    { 
    #region Properties
        [SerializeField]
        private float speed = 10;
        public float Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        [SerializeField]
        private float destroyTime = 5;
        public float DestroyTime
        {
            get
            {
                return destroyTime;
            }
            set
            {
                destroyTime = value;
            }
        }
        #endregion
    }

}
