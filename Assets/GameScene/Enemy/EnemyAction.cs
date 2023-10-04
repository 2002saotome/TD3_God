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
             Enemyaction= Random.Range(1, 6); //1～5ランダム
            EnemyTurn = 0;
        }

      
        switch (Enemyaction)
        {
            case 1:
                EnemyActionText.text = "1ダメージを受けた";
                Debug.Log("\nスライムから1ダメージを受けた");
                break;
            case 2:
                EnemyActionText.text = "2ダメージを受けた";
                Debug.Log("\nスライムから2ダメージを受けた");
                break;
            case 3:
                EnemyActionText.text = "3ダメージを受けた";
                Debug.Log("\nスライムから3ダメージを受けた");
                break;
            case 4:
                EnemyActionText.text = "4ダメージを受けた";
                Debug.Log("\nスライムから4ダメージを受けた");
                break;
            case 5:
                EnemyActionText.text = "5ダメージを受けた";
                Debug.Log("\nスライムから5ダメージを受けた");
                break;
        }
    }
}
