using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace com.Macrobian.Games
{
    public class MenuView : MonoBehaviour
    {
        #region PrivateVariable
        private ApplicationModel applicationModel;
        #endregion

        #region SerializeField
        [SerializeField]
        private GameView gameView;
        [SerializeField]
        private Button btnPlay;
        #endregion

        #region MonoBehaviour
        void Start()
        {
            applicationModel = FindObjectOfType<ApplicationModel>();

            btnPlay.onClick.AddListener(delegate {
                applicationModel.MenuPanel.SetActive(false);
                applicationModel.GamePanel.SetActive(true);

                gameView.SetUpGameView();
            });
        }
        #endregion

    }
}
