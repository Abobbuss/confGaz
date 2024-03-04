using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f; // Скорость передвижения игрока

    void Update()
    {
        // Получаем ввод от клавиатуры
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Определяем направление движения
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Применяем скорость передвижения и deltaTime для плавности
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
