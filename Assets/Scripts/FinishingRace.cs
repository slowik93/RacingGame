using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

///<summary>
/// Class that support an event of finishing race by player.
///</summary>
public class FinishingRace : MonoBehaviour
{
    public GameObject MyCar;
    public GameObject ButtonMenu;
    public int DidWon;
    public GameObject FinalMessage;

    ///<summary>
    /// Methode that detected a collision of player car and finish line trigger.
    ///</summary>
    void OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag == "PlayerCar"){
            
            if(DidWon!=2){
                DidWon=1;
                FinalMessage.SetActive(true);
                FinalMessage.GetComponent<TMPro.TextMeshProUGUI>().text = "You won";

            ButtonMenu.SetActive(true);
            CarController.m_Topspeed=0.0f;
            MyCar.GetComponent<CarController> ().enabled = false;
            MyCar.GetComponent<CarUserControl> ().enabled = false;
            }
        }
    }
    
    ///<summary>
    /// Methode that deactive a final button.
    ///</summary>
    void Start()
    {
        ButtonMenu.SetActive(false);
    }

}
