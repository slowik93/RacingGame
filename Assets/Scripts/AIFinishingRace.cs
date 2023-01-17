using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

///<summary>
/// Class used to activate an ending of race for AI car.
///</summary>
public class AIFinishingRace : MonoBehaviour
{
    public GameObject MyCar;
    public GameObject ButtonMenu;
    public int DidWon;
    public GameObject FinalMessage;

    ///<summary>
    /// Methode that detected a collision of AI car and finish line trigger.
    ///</summary>
    void OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag == "AICar"){
            if(DidWon!=1){
                DidWon=2;
                FinalMessage.SetActive(true);
                FinalMessage.GetComponent<TMPro.TextMeshProUGUI>().text = "You lose";
            }
            MyCar.SetActive (false);
            CarController.m_Topspeed=0.0f;
            MyCar.GetComponent<CarController> ().enabled = false;
            MyCar.GetComponent<CarUserControl> ().enabled = false;
            MyCar.SetActive (true);
            ButtonMenu.SetActive(true);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        ButtonMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
