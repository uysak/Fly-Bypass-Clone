using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private bool _isTouch;
    private Touch _touch;
    private Vector2 _touchStartPos;
    private Vector2 _touchEndPos;

    private float _direction;
    private float _scaledDirection;
    private int _screenWidth = 800;


    // Start is called before the first frame update
    void Start()
    {
        _touch = Input.GetTouch(0);
        _screenWidth = Screen.width;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            _touch = Input.GetTouch(0);
            
            if(_touch.phase == TouchPhase.Began)
            {
                _touchStartPos = _touch.position;
                //_touchStartPos.Normalize();
            }
            else if(_touch.phase == TouchPhase.Moved || _touch.phase == TouchPhase.Stationary)
            {
                _touchEndPos = _touch.position;
                //_touchEndPos.Normalize();

                _direction = _touchEndPos.x - _touchStartPos.x;
                
            }

            else
            {
                _direction = 0;
            }

            _scaledDirection = Scale(_direction, Screen.width * -1, Screen.width, -1, 1);


            Debug.Log(_scaledDirection);
        }
    }
    private float Scale(float value, int min, int max, int minScale, int maxScale)
    {
        float scaled = minScale + (float)(value - min) / (max - min) * (maxScale - minScale);
        return scaled;
    }

    public float getDirection()
    {
        return _scaledDirection;
    }
   
}
