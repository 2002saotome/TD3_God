using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAction : MonoBehaviour
{
    public Text EnemyActionText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int EnemyTurn = 0;
        int Enemyaction=0;

        if (EnemyTurn==0)
        {
             Enemyaction= Random.Range(1, 6); //1�`5�����_��
            EnemyTurn = 0;
        }

      
        switch (Enemyaction)
        {
            case 1:
                EnemyActionText.text = "1�_���[�W���󂯂�";
                Debug.Log("\n�X���C������1�_���[�W���󂯂�");
                break;
            case 2:
                EnemyActionText.text = "2�_���[�W���󂯂�";
                Debug.Log("\n�X���C������2�_���[�W���󂯂�");
                break;
            case 3:
                EnemyActionText.text = "3�_���[�W���󂯂�";
                Debug.Log("\n�X���C������3�_���[�W���󂯂�");
                break;
            case 4:
                EnemyActionText.text = "4�_���[�W���󂯂�";
                Debug.Log("\n�X���C������4�_���[�W���󂯂�");
                break;
            case 5:
                EnemyActionText.text = "5�_���[�W���󂯂�";
                Debug.Log("\n�X���C������5�_���[�W���󂯂�");
                break;
        }
    }
}
