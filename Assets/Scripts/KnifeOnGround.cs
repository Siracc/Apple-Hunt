using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeOnGround : MonoBehaviour
{
    Text _puanText;
    int _puan;


    private void Awake()
    {
        _puanText = GameObject.FindGameObjectWithTag("Text").GetComponent<Text>();

    }

    private void Start()
    {
        _puan = int.Parse(_puanText.text);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("RedApple"))
        {
            _puan += 5;
            _puanText.text = _puan.ToString();           
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("GreenApple"))
        {
            _puan += 10;
            _puanText.text = _puan.ToString();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("BlackApple"))
        {
            PlayerPrefs.SetInt("GameOver", 1);
            Destroy(collision.gameObject);
            Destroy(gameObject);
 

        }
    }
}
