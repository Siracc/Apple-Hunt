using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject _bmb;
    [SerializeField] Transform _spawnTransform;



    private void FixedUpdate()
    {
        KnifeSpawn();
    }

    void KnifeSpawn()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_bmb, _spawnTransform.position, _spawnTransform.rotation, _spawnTransform.parent);
        }        
    }
}
