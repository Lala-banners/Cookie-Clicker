using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : ButtonParent
{
    public bool puppyBought = false;

    // Update is called once per frame
    void Update()
    {
       //Checks if the upgrade button is puppyBought 
        if (puppyBought)
        {
            //Adds puppyBucks to puppyEarns (which in Unity right now is 1 --> will be changed later) automatically --> time
            GameData.puppyBucks += puppyEarns * Time.deltaTime;
        }
    }

    /// <summary>
    /// Makes puppyBought bool true
    /// </summary>
    public void BuyOne()
    {
        //Checks if you have enough puppyBucks to buy an upgrade
        if (GameData.puppyBucks >= upgradeCost)
        {
            puppyBought = true;
        }

    }
}
