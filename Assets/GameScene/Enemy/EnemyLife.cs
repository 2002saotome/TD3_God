using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{

    [SerializeField] private GameObject enemyLife30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyLife30.SetActive(false);
        int enemylife = 30;
        if (enemylife >= 30)
        {
            enemyLife30.SetActive(true);
        }
    }
}
