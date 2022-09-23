using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI ���� ���̺귯��
using UnityEngine.SceneManagement; // �� ���� ���̺귯��
using TMPro; // TextMeshPro ���� ���̺귯��

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText; // ���ӿ��� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    public TextMeshProUGUI TimeText; // ���� �ð��� ǥ���� TextMeshPro ������Ʈ
    public Text recordText; // �ְ� ����� ǥ���� TextMeshPro

    private float surviveTime; // ���� �ð�
    private bool isGameover; // ���ӿ��� ����

    void Start()
    {
        // ���� �ð��� ���ӿ��� ���� �ʱ�ȭ
        surviveTime = 0f;
        isGameover = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���ӿ����� �ƴ� ����
        if (!isGameover)
        {

            // ���� �ð� ����
            surviveTime += Time.deltaTime;
            // ������ ���� �ð��� timeText
            // timeText.text = "Time : " + (int)surviveTime;
        }
        else
        {
            // ���ӿ������¿��� RŰ�� �����ٸ�,
            if (Input.GetKeyDown(KeyCode.R))
            {
                // MainScene �� �ε�
                SceneManager.LoadScene("MainScene");
            }
        }
    }
                // ���� ���¸� ���ӿ��� ���·� ��ȯ
                isGameover = true;
                // ���ӿ��� �ؽ�Ʈ ���� ������Ʈ�� Ȱ��ȭ
                gameoverText.SetActive(true);
}
