using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYERCONTROLLER : MonoBehaviour
{
    public Rigidbody playerRigidbody; // �̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f; // �̵� �ӷ�
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true) { 
        // ���� ����Ű �Է��� ������ ��� z ���� �� �ֱ�
        }

        if (Input.GetKey(KeyCode.DownArrow) == true) { }
    }
}
