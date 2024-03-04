using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    private readonly string MouseX = "Mouse X";
    private readonly string MouseY = "Mouse Y";

    [SerializeField] private float _speed;
    [SerializeField] private Transform _camera;
    [SerializeField] private Transform _body;

    [SerializeField] private float _upDownRange = 90f;
    private float _xRotation = 0f;

    private void Update()
    {
        float mouseX = Input.GetAxis(MouseX) * _speed * Time.deltaTime;
        float mouseY = Input.GetAxis(MouseY) * _speed * Time.deltaTime;

        _body.Rotate(Vector3.up * mouseX);

        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -_upDownRange, _upDownRange);
        _camera.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
    }
}
