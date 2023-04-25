using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.Macrobian.Games
{
    public class ApplicationModel : MonoBehaviour
    {
        #region Properties
        [SerializeField]
        private GameObject menuPanel;
        public GameObject MenuPanel
        {
            get
            {
                return menuPanel;
            }
        }

        [SerializeField]
        private GameObject gamePanel;
        public GameObject GamePanel
        {
            get
            {
                return gamePanel;
            }
        }

        [SerializeField]
        private GameObject gameOverPanel;
        public GameObject GameOverPanel
        {
            get
            {
                return gameOverPanel;
            }
        }
        #endregion
    }
}
