using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private ClickOnLola lola;

    public Upgrades[] upgrades;
    public Text puppyBucksText;
    public static float puppyBucks;
    #endregion
    
    // Update is called once per frame
    void Update()
    {
        //Mathf makes the decimal into a whole number (integer)
        //ToString turns puppyBucks into a string
        puppyBucksText.text = "Available Puppy Bucks:" + Mathf.RoundToInt(puppyBucks).ToString();
    }

    public void Quit()
    {
        Application.Quit();
    }

}
