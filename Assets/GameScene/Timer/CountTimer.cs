using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CountTimer : MonoBehaviour
{

    //�J�E���g�_�E��
    public float countdown = 5.0f;

    //���Ԃ�\������Text�^�̕ϐ�
    public Text timeText;

    // Update is called once per frame
    void Update()
    {

        //���Ԃ��J�E���g�_�E������
        countdown -= Time.deltaTime;

        //���Ԃ�\������
        timeText.text = countdown.ToString("f1") + "�b";

        //countdown��0�ȉ��ɂȂ����Ƃ�
        if (countdown <= 0)
        {
            timeText.text = "���ԂɂȂ�܂����I";
        }
    }
}
