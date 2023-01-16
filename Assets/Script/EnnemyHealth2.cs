using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyHealth2 : MonoBehaviour
{
    #region Exposed

    [SerializeField]
    int _bigEnnemyHealth = 10;
    #endregion

    #region Unity Lifecycle
    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"));
        {
            _bigEnnemyHealth--;
                if (_bigEnnemyHealth <= 0)
            {
                _gameManager.EnnemiesDecreament();
                Destroy(gameObject);
            }
        }
    }
    #endregion

    #region Methods

    #endregion

    #region Private & Protected
    private GameManager _gameManager;
    #endregion
}
