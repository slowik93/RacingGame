using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>
/// Class that support a situation when player buy an element in hte shop.
///</summary>
public class UnlockedItems : MonoBehaviour
{
    public static int BlueBought;
    public static int YellowBought;
    public static int BlackBought;
    public static int LakeBought;
    public Button BlueButton;
    public Button YellowButton;
    public Button BlackButton;
    public Button LakeButton;
    public Button UnBlueButton;
    public Button UnYellowButton;
    public Button UnBlackButton;
    public Button UnLakeButton;

    ///<summary>
    /// Methode that unlock a blue car model.
    ///</summary>
    public void BuyBlue(){
        BlueButton.interactable=true;
        UnBlueButton.interactable=false;
        CashSystem.TotalCash-=100;
        BlueBought=1;
    }
    ///<summary>
    /// Methode that unlock a yellow car model.
    ///</summary>
    public void BuyYellow(){
        YellowButton.interactable=true;
        UnYellowButton.interactable=false;
        CashSystem.TotalCash-=150;
        YellowBought=1;
    }
    ///<summary>
    /// Methode that unlock a black car model.
    ///</summary>
    public void BuyBlack(){
        BlackButton.interactable=true;
        UnBlackButton.interactable=false;
        CashSystem.TotalCash-=200;
        BlackBought=1;
    }
    ///<summary>
    /// Methode that unlock a lake race track.
    ///</summary>
    public void BuyLake(){
        LakeButton.interactable=true;
        UnLakeButton.interactable=false;
        CashSystem.TotalCash-=300;
        LakeBought=1;
    }
}
