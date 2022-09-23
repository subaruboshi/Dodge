using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI 관련 라이브러리
using UnityEngine.SceneManagement; // 씬 관련 라이브러리
using TMPro; // TextMeshPro 관련 라이브러리

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText; // 게임오버 시 활성화할 텍스트 게임 오브젝트
    public TextMeshProUGUI TimeText; // 생존 시간을 표시할 TextMeshPro 컴포넌트
    public Text recordText; // 최고 기록을 표시할 TextMeshPro

    private float surviveTime; // 생존 시간
    private bool isGameover; // 게임오버 상태

    void Start()
    {
        // 생존 시간과 게임오버 상태 초기화
        surviveTime = 0f;
        isGameover = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        // 게임오버가 아닌 동안
        if (!isGameover)
        {

            // 생존 시간 갱신
            surviveTime += Time.deltaTime;
            // 갱신한 생존 시간을 timeText
            // timeText.text = "Time : " + (int)surviveTime;
        }
        else
        {
            // 게임오버상태에서 R키를 누른다면,
            if (Input.GetKeyDown(KeyCode.R))
            {
                // MainScene 을 로드
                SceneManager.LoadScene("MainScene");
            }
        }
    }
                // 현재 상태를 게임오버 상태로 전환
                isGameover = true;
                // 게임오버 텍스트 게임 오브젝트를 활성화
                gameoverText.SetActive(true);
}
