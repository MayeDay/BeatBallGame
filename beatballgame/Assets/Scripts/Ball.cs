using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Define private variables
    float _speed = 24f;
    Rigidbody _rigidbody;
    Vector3 _velocity;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.velocity = Vector3.down * _speed;
    }

    void FixedUpdate()
    {
        //the ball will have 20 units per second speed
        _rigidbody.velocity = _rigidbody.velocity.normalized * _speed;
        _velocity = _rigidbody.velocity;
    }

    private void OnCollisionEnter(Collision collision) {
        _rigidbody.velocity = Vector3.Reflect(_velocity, collision.contacts[0].normal);
    }

}
