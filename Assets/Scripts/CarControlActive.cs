using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

///<summary>
/// Class that activate a control of cars.
///</summary>
public class CarControlActive : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject AICar;

    ///<summary>
    /// Methode that activate a cars control.
    ///</summary>
    void Start()
    {
        CarControlActivate();
    }
    ///<summary>
    /// Methode that turning on a cars control.
    ///</summary>
    public void CarControlActivate()
    {
        CarControl.GetComponent<CarUserControl>().enabled = true;
        AICar.GetComponent<CarAIControl>().enabled = true;
    }

}
