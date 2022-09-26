using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYERCONTROLLER : MonoBehaviour
{
    public Rigidbody playerRigidbody; // 이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f; // 이동 속력
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true) { 
        // 위쪽 방향키 입력이 감지된 경우 z 방향 힘 주기
        }

        if (Input.GetKey(KeyCode.DownArrow) == true) { }
    }
}
