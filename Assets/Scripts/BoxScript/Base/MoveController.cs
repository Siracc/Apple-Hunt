using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : IMove
{

    public float VerticalAxis => Input.GetAxis("Vertical") * Time.deltaTime;
    

    public void Vertical(Transform _transform, float _climbSpeed, bool _isVerticalActive)
    {
        switch (_isVerticalActive)
        {
            case true:
                _transform.position += new Vector3(0, VerticalAxis * _climbSpeed);
                break;
            default:
                _isVerticalActive = false;
                break;
        }
    }
}
