using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeMove : MonoBehaviour
{
    Rigidbody2D _rgdb2D;
   

    [SerializeField] float _speed;

    private void Awake()
    {
        _rgdb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        KnifeMover();
    }

    void KnifeMover()
    {
        _rgdb2D.AddForce(Vector2.right * _speed * Time.deltaTime);
    }
}
