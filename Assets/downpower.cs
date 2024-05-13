using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downpower : MonoBehaviour
{
    public float forceMagnitude; // �������� ����
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("��������� �� ������ �� �������!");
            enabled = false; // ��������� ������
        }
    }

    void FixedUpdate()
    {
        // ������� ������ ����, ������������ � ������������� ����������� ��� Z �������� ������������
        Vector3 force = Vector3.forward * forceMagnitude;

        // ��������� ��� ���� � �������
        rb.AddForce(force, ForceMode.Force);
    }
}
