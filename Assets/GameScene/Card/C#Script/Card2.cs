using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card2 : MonoBehaviour
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

    }
    // Update is called once per frame
    void Update()
    {
        Sword.SetActive(false);
        DualWielding.SetActive(false);
        Knife.SetActive(false);
        Shield.SetActive(false);
        Shield2.SetActive(false);
        RedShield.SetActive(false);
        Portion.SetActive(false);
        Bomb.SetActive(false);
        Abyss.SetActive(false); //˜g

        int rand = Random.Range(1, 9); //1`8ƒ‰ƒ“ƒ_ƒ€

        switch (rand)
        {
            //—”‚Ì”š‚ª1‚È‚çŒ•‚ğ•\¦
            case 1:
                //Œ•‚ğ•\¦
                Sword.SetActive(true);
                break;
            case 2:
                DualWielding.SetActive(true);
                break;
            case 3:
                Knife.SetActive(true);
                break;
            case 4:
                Shield.SetActive(true);
                break;
            case 5:
                Shield2.SetActive(true);
                break;
            case 6:
                RedShield.SetActive(true);
                break;
            case 7:
                Portion.SetActive(true);
                break;
            case 8:
                Bomb.SetActive(true);
                break;
        }
    }
}
