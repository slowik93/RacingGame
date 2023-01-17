using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// Class that support a reset all progress.
///</summary>
public class ResetProgress : MonoBehaviour
{
    ///<summary>
    /// Methode that reset all progress in game.
    ///</summary>
    public void ResetProg(){
        CashSystem.TotalCash=0;
        UnlockedItems.BlueBought=0;
        UnlockedItems.YellowBought=0;
        UnlockedItems.BlackBought=0;
        UnlockedItems.LakeBought=0;
    }
}
