using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeLifeTime : MonoBehaviour
{
    [SerializeField] float _currentTime, _lifeTime;


    private void FixedUpdate()
    {
        Life();
    }


    void Life()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime > _lifeTime)
        {
            Destroy(gameObject);
        }
    }
}
