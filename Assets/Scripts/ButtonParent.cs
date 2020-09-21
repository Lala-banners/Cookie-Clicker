using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonParent : MonoBehaviour
{
    #region Variables
    public float puppyEarns;
    public float upgradeCost;
    public int level;
    public float costMultiplier;
    public string puppyText;
    public Text labelText;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        //Sets label in game
        puppyText = "Ribbon Level" + level.ToString() + "$" + upgradeCost.ToString();

        //Connects labelText and puppyText together
        labelText.text = puppyText;
    }

    public void Upgrade()
    {
        if (GameData.puppyBucks >= upgradeCost)
        {
            //puppyBucks decreases by upgradeCost,
            //which will increase in next line so the upgrades get more expensive = lose more puppyBucks
            GameData.puppyBucks -= upgradeCost;

            //upgradeCost increases by multiplying by costMultiplier
            upgradeCost *= costMultiplier;

            //puppyEarns multiplied by 2
            puppyEarns *= 2;

            //Level (of the upgrade button) increases
            level++;
        }

        //Sets label in game
        puppyText = "Ribbon Level" + level.ToString() + "$" + upgradeCost.ToString();

        //Connects labelText and puppyText together
        labelText.text = puppyText;
    }
}
