using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rand2 : MonoBehaviour
{
    [SerializeField] private GameObject Sword;
    // Start is called before the first frame update
    void Start()
    {
        Sword.SetActive(false);
        int rand = Random.Range(1, 9); //1�`8�����_��

        switch (rand)
        {
            //�����̐�����1�Ȃ猕��\��
            case 1:
                Debug.Log("��");
                break;
            case 2:
                Debug.Log("�񓁗�");
                break;
            case 3:
                Debug.Log("��");
                break;
            case 4:
                Debug.Log("��");
                break;
            case 5:
                Debug.Log("��2");
                break;
            case 6:
                Debug.Log("�Ԃ���");
                break;
            case 7:
                Debug.Log("�|�[�V����");
                break;
            case 8:
                Debug.Log("���e");
                break;
        }


        if (rand == 1)
        {
            //����\��
            Sword.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
