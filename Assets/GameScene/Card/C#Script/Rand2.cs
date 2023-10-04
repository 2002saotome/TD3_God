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
        int rand = Random.Range(1, 9); //1～8ランダム

        switch (rand)
        {
            //乱数の数字が1なら剣を表示
            case 1:
                Debug.Log("剣");
                break;
            case 2:
                Debug.Log("二刀流");
                break;
            case 3:
                Debug.Log("刀");
                break;
            case 4:
                Debug.Log("盾");
                break;
            case 5:
                Debug.Log("盾2");
                break;
            case 6:
                Debug.Log("赤い盾");
                break;
            case 7:
                Debug.Log("ポーション");
                break;
            case 8:
                Debug.Log("爆弾");
                break;
        }


        if (rand == 1)
        {
            //剣を表示
            Sword.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
