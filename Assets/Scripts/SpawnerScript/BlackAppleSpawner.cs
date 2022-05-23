using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackAppleSpawner : MonoBehaviour
{
    [SerializeField] GameObject _blackApple;
    [SerializeField] Transform _appleTransform;

    [Range(5, 10)] [SerializeField] float _minSpawnTime;
    [Range(10, 13)] [SerializeField] float _maxSpawnTime;

    [SerializeField] float _randomSpawnTimeApple, _currentTimeBlackApple;



    void Update()
    {
        _currentTimeBlackApple += Time.deltaTime;

        if (_currentTimeBlackApple > _randomSpawnTimeApple && _currentTimeBlackApple !=0)
        {
            BlackAppleSpawnStart();
        }
    }

    void BlackAppleSpawnStart()
    {
        Instantiate(_blackApple, _appleTransform.position, _appleTransform.rotation);
        ResetTimeBlackApple();
    }

    void ResetTimeBlackApple()
    {
        _currentTimeBlackApple = 0;
        _randomSpawnTimeApple = Random.Range(_minSpawnTime, _maxSpawnTime);
    }
}
