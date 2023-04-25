using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace com.Macrobian.Games
{
    public class GameView : MonoBehaviour
    {
        #region PrivateVariables
        private PlayerView playerView;
        private GameModel gameModel;
        private GameController gameController;
        private ApplicationModel applicationModel;
        private int currSeconds=0;
        #endregion

        #region SerializeFields
        [SerializeField]
        private GameObject playerObj;
        [SerializeField]
        private GameObject reloadImg;
        [SerializeField]
        private Text txtBulletCounter;
        [SerializeField]
        private Text timerText;
        [SerializeField]
        private Button btnShoot;
        #endregion


        #region PrivateMethods
        private void StartTimer()
        {
            ShowText(timerText, gameModel.GameTimer.ToString());

            InvokeRepeating(nameof(Timer), 1, 1);
        }

        private void Timer()
        {
            int remainTime = gameController.IncreaseTimer(ref currSeconds);

            ShowText(timerText, remainTime.ToString());

            if (remainTime <= 0)
            {
                CancelInvoke(nameof(Timer));

                applicationModel.GamePanel.SetActive(false);
                applicationModel.GameOverPanel.SetActive(true);
            }
        }

        private void ShowText(Text timerText, string value)
        {
            timerText.text = value;
        }

        private void SpawnPlayer()
        {
            playerView = Instantiate(playerObj, new Vector3(0, 0.5f, 0), Quaternion.identity).GetComponent<PlayerView>();
            playerView.GameView = this;

            Camera.main.transform.parent = playerView.transform;
            Camera.main.transform.localPosition = new Vector3(0, 2, -5);
        }
        #endregion


        #region PrivateMethods
        private void HideImg()
        {
            playerView.WeaponView.Reset();
            reloadImg.SetActive(false);
            btnShoot.interactable = true;
        }

        private void AssignListeners()
        {
            btnShoot.onClick.AddListener(playerView.WeaponView.Shoot);
        }
        #endregion


        #region PublicMethods
        public void SetUpGameView()
        {
            applicationModel = FindObjectOfType<ApplicationModel>();
            gameModel = (GameModel)Resources.Load("GameModel");
            gameController = new GameController(gameModel);

            SpawnPlayer();
            StartTimer();

            Invoke(nameof(AssignListeners), 1);
        }

        public void ShowBulletCounter(int bulletCounter, int maxBullets)
        {
            txtBulletCounter.text = bulletCounter + "/" + maxBullets;
        }

        public void CheckBullets(bool isBulletAvailable, float reloadTime)
        {
            if (!isBulletAvailable)
            {
                btnShoot.interactable = false;
                reloadImg.SetActive(true);
                Invoke(nameof(HideImg), reloadTime);
            }
        }
        #endregion
    }
}
