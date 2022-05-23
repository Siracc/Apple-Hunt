using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{

    MoveController _moverController;

    [SerializeField] Transform _boxTransform;
    [SerializeField] float _verticalSpeed;
    [SerializeField] bool _isVerticalActive;


    private void Awake()
    {
        _moverController = new MoveController();
    }

    private void FixedUpdate()
    {
        BoxMover();
       
    }

    void BoxMover()
    {
        _moverController.Vertical(_boxTransform, _verticalSpeed, _isVerticalActive);
    }

 

}
