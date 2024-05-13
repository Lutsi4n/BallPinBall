using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downpower : MonoBehaviour
{
    public float forceMagnitude; // Величина силы
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Ригидбоди не найден на объекте!");
            enabled = false; // Отключаем скрипт
        }
    }

    void FixedUpdate()
    {
        // Создаем вектор силы, направленный в отрицательном направлении оси Z мирового пространства
        Vector3 force = Vector3.forward * forceMagnitude;

        // Применяем эту силу к объекту
        rb.AddForce(force, ForceMode.Force);
    }
}
