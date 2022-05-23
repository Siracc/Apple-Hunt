using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackAppleLifeTime : MonoBehaviour
{
    [SerializeField] float _currentTime;
    [Range(1, 10)] [SerializeField] float _lifeTime;


    private void FixedUpdate()
    {
        LifeTime();
    }


    void LifeTime()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime > _lifeTime)
        {
            Destroy(gameObject);
        }
    }
}
