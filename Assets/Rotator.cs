using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private int _speed;

    void Update()
    {
        transform.Rotate(Vector3.up, _speed * Time.deltaTime);
    }
}
