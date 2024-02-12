using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public static LevelManager main;

    public Transform startPoint;
    public Transform[] path;

    public int geld;
    public int maxLevens = 10;
    public int huidigeLevens;  

    //hier moet public en dan de deathanimatie

    private void Start()
    {
        huidigeLevens = maxLevens;
        geld = 130;
    }

    public void NeemSchade(int amount)
    {
        huidigeLevens -= amount;

        if(huidigeLevens <= 0)
        {
            //death screen
        }
    }


    private void Awake() {
        main = this;
    }

    public void IncreaseCurrency(int amount) {
        geld += amount;
    }

    public bool SpendCurrency(int amount) {
        if (amount <= geld){
            geld -= amount;
            return true;
        } else {
            Debug.Log("You do not have enough to purchase this tiem");
            return false;
        }
    }
}
