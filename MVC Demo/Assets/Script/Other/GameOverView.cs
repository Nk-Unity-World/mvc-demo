using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace com.Macrobian.Games
{
    public class GameOverView : MonoBehaviour
    {
        #region SerializeField
        [SerializeField]
        private Button btnRestart;
        #endregion

        #region Monobehaviour
        void Start()
        {
            btnRestart.onClick.AddListener(delegate
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name.ToString());
            });
        }
        #endregion
    }
}
