using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _speed = 5.0f;

    private bool _canMove;

    private const string HorizontalInput = "Horizontal";
    private const string VerticallInput = "Vertical";

    private void Update()
    {
        if (_canMove)
        {
            float moveHorizontal = Input.GetAxis(HorizontalInput);
            float moveVertical = Input.GetAxis(VerticallInput);

            if (moveHorizontal != 0 || moveVertical != 0)
            {
                Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

                Move(movement);
            }
        }
    }

    private void Move(Vector3 movement) => transform.Translate(movement * _speed * Time.deltaTime);

    private void OnEnable()
    {
        _player.StopPlaying += StopMoving;
        _player.Playing += StartMoving;
    }

    private void OnDisable()
    {
        _player.StopPlaying -= StopMoving;
        _player.Playing -= StartMoving;
    }

    private void StopMoving() => _canMove = false;
    private void StartMoving() => _canMove = true;
}
