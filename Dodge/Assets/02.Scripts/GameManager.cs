using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI 관련 라이브러리
using UnityEngine.SceneManagement; // 씬 관련 라이브러리
using TMPro; // TextMeshPro 관련 라이브러리

public class GameManager : MonoBehaviour
{
    public GameObect GameoverText; // 게임오버 시 활성화할 텍스트 게임 오브젝트
    public Text TimeText; // 생존 시간을 표시할 텍스트 컴포넌트
    public Text recordText; // 최고 기록을 표시할 텍스트 컴포넌트

    private float surviveTime; // 생존 시간
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
