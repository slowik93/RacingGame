using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// Class that load a correct moddel car in race.
///</summary>
public class ChoiceCar : MonoBehaviour
{
    public GameObject RedBody;
    public GameObject BlueBody;
    public GameObject YellowBody;
    public GameObject BlackBody;
    public GameObject RedBodyPilot;
    public GameObject BlueBodyPilot;
    public GameObject YellowBodyPilot;
    public GameObject BlackBodyPilot;
    public int CarImport;
    
    ///<summary>
    /// Methode that start a main methode with chosen car.
    ///</summary>
    void Start()
    {
        ChosenCar();
    }
    ///<summary>
    /// Methode that load a correct model of car in game.
    ///</summary>
    public void ChosenCar()
    {
        BlackBody.SetActive(false);
        CarImport = GlobalCar.CarType;
        if(CarImport == 1){
            RedBody.SetActive(true);
            RedBodyPilot.SetActive(true);
        }
        if(CarImport == 2){
            BlueBody.SetActive(true);
            BlueBodyPilot.SetActive(true);
        }
        if(CarImport == 3){
            YellowBody.SetActive(true);
            YellowBodyPilot.SetActive(true);
        }
        if(CarImport == 4){
            BlackBody.SetActive(true);
            BlackBodyPilot.SetActive(true);
        }
    }
}
