using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.Macrobian.Games
{
    public class GameController
    {
        #region PrivateVariable
        private GameModel gameModel;
        #endregion

        #region PublicMethods
        public GameController(GameModel gameModel)
        {
            this.gameModel = gameModel;
        }

        public int IncreaseTimer(ref int currSeconds)
        {
            currSeconds++;

            int remainTimer = gameModel.GameTimer - currSeconds;//30-1
            return remainTimer >=0 ? remainTimer :0;
        }
        #endregion
    }
}
