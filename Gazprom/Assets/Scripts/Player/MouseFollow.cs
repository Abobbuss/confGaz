using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Transform _camera;
    [SerializeField] private Transform _body;
    [SerializeField] private float _speed;
    [SerializeField] private float _upDownRange = 90f;

    private float _xRotation = 0f;
    private bool _canFollow;

    private readonly string MouseX = "Mouse X";
    private readonly string MouseY = "Mouse Y";

    private void Update()
    {
        if (_canFollow)
        {
            float mouseX = Input.GetAxis(MouseX) * _speed * Time.deltaTime;
            float mouseY = Input.GetAxis(MouseY) * _speed * Time.deltaTime;

            _body.Rotate(Vector3.up * mouseX);

            _xRotation -= mouseY;
            _xRotation = Mathf.Clamp(_xRotation, -_upDownRange, _upDownRange);
            _camera.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        }
    }

    private void OnEnable()
    {
        _player.StopPlaying += DisableFollow;
        _player.Playing += EnableFollow;
    }

    private void OnDisable()
    {
        _player.StopPlaying -= DisableFollow;
        _player.Playing -= EnableFollow;
    }

    private void EnableFollow() => _canFollow = true;
    private void DisableFollow() => _canFollow = false;
}
