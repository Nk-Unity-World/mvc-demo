using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.Macrobian.Games
{
    [CreateAssetMenu(fileName ="GameModel",menuName ="NkObjects/GameModel",order =1)]
    public class GameModel : ScriptableObject
    {
        #region Properties
        [SerializeField]
        private int gameTimer;
        public int GameTimer
        {
            set
            {
                gameTimer = value;
            }
            get
            {
                return gameTimer;
            }
        }
        #endregion
    }
}
