using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// Class that load a chosen model of car in a game.
///</summary>
public class GlobalCar : MonoBehaviour
{
    public static int CarType;
    public GameObject GameModeWindow;

    ///<summary>
    /// Methode that set a first car model in game.
    ///</summary>
    public void Car1(){
        CarType = 1;
        GameModeWindow.SetActive(true);
    }
    ///<summary>
    /// Methode that set a second car model in game.
    ///</summary>
    public void Car2(){
        CarType = 2;
        GameModeWindow.SetActive(true);
    } 
    ///<summary>
    /// Methode that set a third car model in game.
    ///</summary>
    public void Car3(){
        CarType = 3;
        GameModeWindow.SetActive(true);
    } 
    ///<summary>
    /// Methode that set a fourth car model in game.
    ///</summary>
    public void Car4(){
        CarType = 4;
        GameModeWindow.SetActive(true);
    }
}
