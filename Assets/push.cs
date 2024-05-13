using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour
{
    public float pushForce; // ���� ������
    private Rigidbody rb;
    private float timer = 2f; // ������ ��� ������������� ��������

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("��������� �� ������ �� �������!");
            enabled = false; // ��������� ������
        }
    }

    void Update()
    {
        // ��������� ������
        timer -= Time.deltaTime;

        // ����� ������ ��������� ���� ��� ������, ������� ������
        if (timer <= 0f)
        {
            Push();
            timer = 10f; // ���������� ������
        }
    }

    void Push()
    {
        // ������� ������ �� ��� Z
        rb.AddForce(-transform.forward * pushForce, ForceMode.Impulse);
    }
}
