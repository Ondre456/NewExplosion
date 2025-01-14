using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private float _power;
    private float _distance;
    private float _duration;
    private float _currentRadius;
    private float _initialRadius;

    private SphereCollider _collider;

    private void Awake()
    {
        _distance = 5;
        _power = 2;
        _initialRadius = 0;
        _duration = 0.1f;
        _collider = gameObject.AddComponent<SphereCollider>();
    }

    private void FixedUpdate()
    {
        if (_currentRadius < _distance)
        {
            _currentRadius = Mathf.Lerp(0f, _distance, Time.time / _duration);
            _collider.radius = _currentRadius;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();

        if (rb != null)
        {
            Vector3 direction = (other.transform.position - transform.position).normalized;
            rb.AddForce(direction * _power, ForceMode.Impulse);
        }
    }
}
