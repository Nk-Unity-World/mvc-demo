using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.Macrobian.Games
{
    public class EnemyView : MonoBehaviour
    {
        #region PrivateVariable
        private MeshRenderer meshRenderer;
        #endregion

        #region Monobehaviour
        void Start()
        {
            meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material.color = new Color
                (Random.Range(0, 255f) / 255f
                , Random.Range(0, 255f) / 255f
                , Random.Range(0, 255f) / 255f);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.other.CompareTag("Bullet"))
            {
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }
        }
        #endregion
    }
}
