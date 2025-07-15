using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _scale;

    private void Start()
    {
        _scale = transform.localScale;
    }

    private void Update()
    {
        transform.localScale = _scale * (1 + _speed * Time.time);
    }
}
