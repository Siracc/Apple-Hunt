using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] _apples;
    [SerializeField] Transform _appleTransform;
    


    [Range(1, 5)] [SerializeField] float _minSpawnTime;
    [Range(2, 6)] [SerializeField] float _maxSpawnTime;

    [SerializeField] float _randomSpawnTimeApple, _currentTimeApple;

    void Update()
    {
        _currentTimeApple += Time.deltaTime;

        if (_currentTimeApple > _randomSpawnTimeApple && _currentTimeApple != 0)
        {
            AppleSpawnStart();
        }
    }

    

    void AppleSpawnStart()
    {
        int _randomIndex = Random.Range(0, _apples.Length);

        Instantiate(_apples[_randomIndex], _appleTransform.position, _appleTransform.rotation);
        ResetTimeApple();
    }

    void ResetTimeApple()
    {
        _currentTimeApple = 0;
        _randomSpawnTimeApple = Random.Range(_minSpawnTime, _maxSpawnTime);
    }   


    
}
