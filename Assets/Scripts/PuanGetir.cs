using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuanGetir : MonoBehaviour
{
    [SerializeField] Text _puanText, _highScoreText;
    int _highScore;

    void Start()
    {
        _highScore = int.Parse(PlayerPrefs.GetString("HighScore"));
        _puanText.text = 0.ToString();
        _highScoreText.text = PlayerPrefs.GetString("HighScore");
    }


    private void FixedUpdate()
    {
        HighScore();
    }


    void HighScore()
    {
        if (int.Parse(_puanText.text) > _highScore)
        {
            _highScore = int.Parse(_puanText.text); 
            _highScoreText.text = _highScore.ToString();
            PlayerPrefs.SetString("HighScore", _highScore.ToString());
        }
    }
}
