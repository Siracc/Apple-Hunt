using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverControl : MonoBehaviour
{

    [SerializeField] GameObject _gameOverPanel;

   [SerializeField] GameObject _fruitSpawner, _spawner, _blackAppleSpawner, _boxMove;

    int _kontrol;
    private void Start()
    {
        PlayerPrefs.SetInt("GameOver", 0);

    }

    private void FixedUpdate()
    {
        GameOver();
    }

    void GameOver()
    {
        _kontrol = PlayerPrefs.GetInt("GameOver");

        if (_kontrol == 1)
        {
            
            _gameOverPanel.SetActive(true);
            _fruitSpawner.GetComponent<FruitSpawner>().enabled = false;
            _spawner.GetComponent<Spawner>().enabled = false;
            _boxMove.GetComponent<BoxMove>().enabled = false;
            _blackAppleSpawner.GetComponent<BlackAppleSpawner>().enabled = false;
            

        }
    }
}
