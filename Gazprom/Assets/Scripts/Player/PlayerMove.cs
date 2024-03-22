using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;

    private const string HorizontalInput = "Horizontal";
    private const string VerticallInput = "Horizontal";

    private void Update()
    {
        float moveHorizontal = Input.GetAxis(HorizontalInput);
        float moveVertical = Input.GetAxis(VerticallInput);

        if (moveHorizontal != 0 || moveVertical != 0)
        {
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            Move(movement);
        }
    }

    private void Move(Vector3 movement) => transform.Translate(movement * _speed * Time.deltaTime);
}
