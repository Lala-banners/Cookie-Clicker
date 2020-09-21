using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnLola : ButtonParent
{
    public void Click()
    {
        //Reference to puppy earns in GameData to add puppyBucks to puppyEarns
        GameData.puppyBucks += puppyEarns;
    }


   
}
