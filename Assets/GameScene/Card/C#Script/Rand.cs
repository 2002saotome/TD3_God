using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rand : MonoBehaviour
{
    [SerializeField] private GameObject Sword;
    [SerializeField] private GameObject DualWielding;
    [SerializeField] private GameObject Knife;
    [SerializeField] private GameObject Shield;
    [SerializeField] private GameObject Shield2;
    [SerializeField] private GameObject RedShield;
    [SerializeField] private GameObject Portion;
    [SerializeField] private GameObject Bomb;
    [SerializeField] private GameObject Abyss;
    // Start is called before the first frame update
    void Start()
    {
        Sword.SetActive(false);
        DualWielding.SetActive(false);
        Knife.SetActive(false);
        Shield.SetActive(false);
        Shield2.SetActive(false);
        RedShield.SetActive(false);
        Portion.SetActive(false);
        Bomb.SetActive(false);
        Abyss.SetActive(false); //�g

        int rand = Random.Range(1, 9); //1�`8�����_��

        switch(rand)
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


        if(rand==1)
        {
            //����\��
            Sword.SetActive(true);
        }

        if(rand==2)
        {
            DualWielding.SetActive(true);
        }

        if (rand==3)
        {
            Knife.SetActive(true);
        }

        if (rand==4)
        {
           Shield.SetActive(true);
        }

        if (rand==5)
        {
            Shield2.SetActive(true);
        }

        if (rand==6)
        {
            RedShield.SetActive(true);
        }

        if (rand==7)
        {
           Portion.SetActive(true);
        }

        if (rand==8)
        {
            Bomb.SetActive(true);
        }

    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Abyss.SetActive(true);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Abyss.SetActive(false);
        }
    }
}
