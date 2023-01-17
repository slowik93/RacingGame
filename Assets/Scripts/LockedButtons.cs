using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>
/// Class that support a locking buttons in shop.
///</summary>
public class LockedButtons : MonoBehaviour
{
    public Button BlueBut;
    public Button YellowBut;
    public Button BlackBut;
    public Button LakeBut;
    public Button UnBlueBut;
    public Button UnYellowBut;
    public Button UnBlackBut;
    public Button UnLakeBut;
    public int Cash;

    ///<summary>
    /// Methode that update a number of cash.
    ///</summary>
    void Update()
    {
        Cash = CashSystem.TotalCash;
        LockButtonsIfNotEnoughCash();
        LockButtonIfNotBought();
    }
    ///<summary>
    /// Methode that set buy buttons locked if player does not have enough money.
    ///</summary>
    void LockButtonsIfNotEnoughCash(){
        if(Cash<100){
            UnBlueBut.interactable = false;
        }
        else{
            UnBlueBut.interactable = true;
        }
        if(Cash<150){
            UnYellowBut.interactable = false;
        }
        else{
            UnYellowBut.interactable = true;
        }
        if(Cash<200){
            UnBlackBut.interactable = false;
        }
        else{
            UnBlackBut.interactable = true;
        }
        if(Cash<300){
            UnLakeBut.interactable = false;
        }
        else{
            UnLakeBut.interactable = true;
        }
    }
    ///<summary>
    /// Methode that set buy buttons locked if player already bought that item.
    ///</summary>
    void LockButtonIfNotBought(){
        if(UnlockedItems.BlueBought==1){
            UnBlueBut.interactable=false;
        }
        else if(UnlockedItems.BlueBought==0){
            BlueBut.interactable=false;
        }
        if(UnlockedItems.YellowBought==1){
            UnYellowBut.interactable=false;
        }
        else if(UnlockedItems.YellowBought==0){
            YellowBut.interactable=false;
        }
        if(UnlockedItems.BlackBought==1){
            UnBlackBut.interactable=false;
        }
        else if(UnlockedItems.BlackBought==0){
            BlackBut.interactable=false;
        }
        if(UnlockedItems.LakeBought==1){
            UnLakeBut.interactable=false;
        }
        else if(UnlockedItems.LakeBought==0){
            LakeBut.interactable=false;
        }
    }
}
