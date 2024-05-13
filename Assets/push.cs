using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour
{
    public float pushForce; // Сила толчка
    private Rigidbody rb;
    private float timer = 2f; // Таймер для периодических толчковы

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Ригидбоди не найден на объекте!");
            enabled = false; // Отключаем скрипт
        }
    }

    void Update()
    {
        // Уменьшаем таймер
        timer -= Time.deltaTime;

        // Когда таймер достигает нуля или меньше, толкаем объект
        if (timer <= 0f)
        {
            Push();
            timer = 10f; // Сбрасываем таймер
        }
    }

    void Push()
    {
        // Толкаем объект по оси Z
        rb.AddForce(-transform.forward * pushForce, ForceMode.Impulse);
    }
}
