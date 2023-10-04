using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMove : MonoBehaviour
{
    //�q�I�u�W�F�N�g�̃T�C�Y�����邽�߂̕ϐ�
    private float Left, Right, Top, Bottom;

    //�J�������猩����ʍ����̍��W������ϐ�
    Vector3 LeftBotton;
    Vector3 RightTop;

    // Start is called before the first frame update
    void Start()
    {
        //�q�I�u�W�F�N�g�̐��������[�v�������s��
        foreach (Transform child in gameObject.transform)
        {
            //�q�I�u�W�F�N�g�̒��ň�ԉE�̈ʒu�ɂ����Ȃ�
            if (child.localPosition.x >= Right)
            {
                //�q�I�u�W�F�N�g�̃��[�J�����W���E�[�p�̕ϐ��ɑ������
                Right = child.transform.localPosition.x;
            }
            //�q�I�u�W�F�N�g�̒��ň�ԍ��ɂ�����
            if (child.localPosition.x <= Left)
            {
                //�q�I�u�W�F�N�g�̃��[�J��X���W�����[�p�̕ϐ��ɑ������
                Left = child.transform.localPosition.x;
            }
            //�q�I�u�W�F�N�g�̒��ň�ԏ�ɂ�����
            if (child.localPosition.y >= Top)
            {
                //�q�I�u�W�F�N�g�̃��[�J��y���W����[�p�̕ϐ��ɑ������
                Top = child.transform.localPosition.y;
            }
            //�q�I�u�W�F�N�g�̒��ň�ԉ��ɂ�����
            if (child.localPosition.y <= Bottom)
            {
                //�q�I�u�W�F�N�g�̃��[�J��y���W�����[�p�̕ϐ��ɑ������
                Bottom = child.transform.localPosition.y;
            }
        }

        //�J�����ƃv���C���[�̋����𑪂�
        var distance = Vector3.Distance(Camera.main.transform.position, transform.position);
        //�X�N���[����ʍ����̈ʒu��ݒ肷��
        LeftBotton = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        //�X�N���[���E��̈ʒu��ݒ肷��
        RightTop = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, distance));
    }

    // Update is called once per frame
    void Update()
    {
        //�v���C���[�̃��[���h���W���擾
        Vector3 pos = transform.position;

        //�E���L�[�������ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //�E������0.1����
            pos.x += 0.1f;
        }
        //�����L�[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //��������0.1����
            pos.x -= 0.1f;
        }
        //����L�[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //�������0.1����
            pos.y += 0.1f;
        }
        //�����L�[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //��������0.1����
            pos.y -= 0.1f;
        }
        //transform.position = new Vector3(pos.x, pos.y, pos.z);

        //�v���C���[�̃��[���h���W�ɑ��
        transform.position = new Vector3(Mathf.Clamp(pos.x, LeftBotton.x + transform.localScale.x - Left,
            RightTop.x - transform.localScale.x - Right),
            pos.y,
            Mathf.Clamp(pos.z, LeftBotton.z + transform.localScale.z - Bottom,
            RightTop.z - transform.localScale.z - Top));
    }
}
