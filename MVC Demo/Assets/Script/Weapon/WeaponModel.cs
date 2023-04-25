using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.Macrobian.Games
{
    [CreateAssetMenu(fileName ="WeaponModel",menuName ="NkObjects/WeaponModel",order =1)] 
    public class WeaponModel : ScriptableObject
    {
        #region SerializeFields
        [SerializeField]
        private int reloadTime;
        public int ReloadTime
        {
            set
            {
                reloadTime = value;
            }
            get
            {
                return reloadTime;
            }
        }

        [SerializeField]
        private int maxBullets;
        public int MaxBullets
        {
            set
            {
                maxBullets = value;
            }
            get
            {
                return maxBullets;
            }
        }
        #endregion
    }
}
