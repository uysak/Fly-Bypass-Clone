using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementManager : MonoBehaviour
{
    InputManager inputManager;
    private float _rotateSpeed = 90f;
    private float _movementSpeed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        inputManager = this.gameObject.GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, inputManager.getDirection() * _rotateSpeed * Time.deltaTime, 0));
        this.transform.Translate(0, 0, _movementSpeed * Time.deltaTime);
    }
}
