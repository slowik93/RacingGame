using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// Class that handle a road for player car in autopilot mode.
///</summary>
public class Autopilot01 : MonoBehaviour
{
    public GameObject Marker;
    public GameObject Mark01;
    public GameObject Mark02;
    public GameObject Mark03;
    public GameObject Mark04;
    public GameObject Mark05;
    public GameObject Mark06;
    public GameObject Mark07;
    public GameObject Mark08;
    public GameObject Mark09;
    public GameObject Mark10;
    public GameObject Mark11;
    public GameObject Mark12;
    public GameObject Mark13;
    public GameObject Mark14;
    public GameObject Mark15;
    public GameObject Mark16;
    public GameObject Mark17;
    public GameObject Mark18;
    public GameObject Mark19;
    public GameObject Mark20;
    public GameObject Mark21;
    public GameObject Mark22;
    public GameObject Mark23;
    public GameObject Marker01b;
    public GameObject Marker02b;
    public GameObject Marker03b;
    public GameObject Marker04b;
    public GameObject Marker05b;
    public GameObject Marker06b;
    public GameObject Marker07b;
    public GameObject Marker08b;
    public GameObject Marker09b;
    public GameObject Marker10b;
    public GameObject Marker11b;
    public GameObject Marker12b;
    public GameObject Marker13b;
    public GameObject Marker14b;
    public GameObject Marker15b;
    public GameObject Marker16b;
    public GameObject Marker17b;
    public GameObject Marker18b;
    public GameObject Marker19b;
    public GameObject Marker20b;
    public GameObject Marker21b;
    public GameObject Marker22b;
    public GameObject Marker23b;
    public GameObject CarUser;
    public GameObject CarAuto;
    public GameObject RedBody;
    public GameObject BlueBody;
    public GameObject YellowBody;
    public GameObject BlackBody;
    public GameObject RedBodyPilot;
    public GameObject BlueBodyPilot;
    public GameObject YellowBodyPilot;
    public GameObject BlackBodyPilot;
    public GameObject SkyCarAuto;
    public static int Tracker;
    public static int Autopilot;
    public Rigidbody CarSpeed;
    public float speed;
    
    ///<summary>
    /// Methode that change a position of tracker.
    ///</summary>
    void Update()
    {
        if(Autopilot==1){
        speed=CarSpeed.velocity.magnitude*3.6f;
        if(speed<1.0){
            StartCoroutine(ResetAutopilot());
        }
        }
        if(Tracker == 0){
            Marker.transform.position = Mark01.transform.position;
            Marker.transform.rotation = Mark01.transform.rotation;
            Marker01b.SetActive(true);
            Marker06b.SetActive(true);
            Marker07b.SetActive(true);
            Marker12b.SetActive(true);
            Marker22b.SetActive(true);
        }
        if(Tracker == 1){
            Marker.transform.position = Mark02.transform.position;
            Marker.transform.rotation = Mark02.transform.rotation;
        }
        if(Tracker == 2){
            Marker.transform.position = Mark03.transform.position;
            Marker.transform.rotation = Mark03.transform.rotation;
        }
        if(Tracker == 3){
            Marker.transform.position = Mark04.transform.position;
            Marker.transform.rotation = Mark04.transform.rotation;
        }
        if(Tracker == 4){
            Marker.transform.position = Mark05.transform.position;
            Marker.transform.rotation = Mark05.transform.rotation;
        }
        if(Tracker == 5){
            Marker.transform.position = Mark06.transform.position;
            Marker.transform.rotation = Mark06.transform.rotation;
        }
        if(Tracker == 6){
            Marker.transform.position = Mark07.transform.position;
            Marker.transform.rotation = Mark07.transform.rotation;
        }
        if(Tracker == 7){
            Marker.transform.position = Mark08.transform.position;
            Marker.transform.rotation = Mark08.transform.rotation;
        }
        if(Tracker == 8){
            Marker.transform.position = Mark09.transform.position;
            Marker.transform.rotation = Mark09.transform.rotation;
        }
        if(Tracker == 9){
            Marker.transform.position = Mark10.transform.position;
            Marker.transform.rotation = Mark10.transform.rotation;
        }
        if(Tracker == 10){
            Marker.transform.position = Mark11.transform.position;
            Marker.transform.rotation = Mark11.transform.rotation;
        }
        if(Tracker == 11){
            Marker.transform.position = Mark12.transform.position;
            Marker.transform.rotation = Mark12.transform.rotation;
        }
        if(Tracker == 12){
            Marker.transform.position = Mark13.transform.position;
            Marker.transform.rotation = Mark13.transform.rotation;
        }
        if(Tracker == 13){
            Marker.transform.position = Mark14.transform.position;
            Marker.transform.rotation = Mark14.transform.rotation;
        }
        if(Tracker == 14){
            Marker.transform.position = Mark15.transform.position;
            Marker.transform.rotation = Mark15.transform.rotation;
        }
        if(Tracker == 15){
            Marker.transform.position = Mark16.transform.position;
            Marker.transform.rotation = Mark16.transform.rotation;
        }
        if(Tracker == 16){
            Marker.transform.position = Mark17.transform.position;
            Marker.transform.rotation = Mark17.transform.rotation;
        }
        if(Tracker == 17){
            Marker.transform.position = Mark18.transform.position;
            Marker.transform.rotation = Mark18.transform.rotation;
        }
        if(Tracker == 18){
            Marker.transform.position = Mark19.transform.position;
            Marker.transform.rotation = Mark19.transform.rotation;
        }
        if(Tracker == 19){
            Marker.transform.position = Mark20.transform.position;
            Marker.transform.rotation = Mark20.transform.rotation;
        }
        if(Tracker == 20){
            Marker.transform.position = Mark21.transform.position;
            Marker.transform.rotation = Mark21.transform.rotation;
        }
        if(Tracker == 21){
            Marker.transform.position = Mark22.transform.position;
            Marker.transform.rotation = Mark22.transform.rotation;
        }
        if(Tracker == 22){
            Marker.transform.position = Mark23.transform.position;
            Marker.transform.rotation = Mark23.transform.rotation;
        }
        if(Tracker == 24){
            Marker.transform.position = Marker02b.transform.position;
            Marker.transform.rotation = Marker02b.transform.rotation;
        }
        if(Tracker == 25){
            Marker.transform.position = Marker03b.transform.position;
            Marker.transform.rotation = Marker03b.transform.rotation;
        }
        if(Tracker == 26){
            Marker.transform.position = Marker04b.transform.position;
            Marker.transform.rotation = Marker04b.transform.rotation;
        }
        if(Tracker == 27){
            Marker.transform.position = Marker05b.transform.position;
            Marker.transform.rotation = Marker05b.transform.rotation;
        }
        if(Tracker == 29){
            Marker.transform.position = Marker08b.transform.position;
            Marker.transform.rotation = Marker08b.transform.rotation;
        }
        if(Tracker == 30){
            Marker.transform.position = Marker09b.transform.position;
            Marker.transform.rotation = Marker09b.transform.rotation;
        }
        if(Tracker == 31){
            Marker.transform.position = Marker10b.transform.position;
            Marker.transform.rotation = Marker10b.transform.rotation;
        }
        if(Tracker == 32){
            Marker.transform.position = Marker11b.transform.position;
            Marker.transform.rotation = Marker11b.transform.rotation;
        }
        if(Tracker == 34){
            Marker.transform.position = Marker12b.transform.position;
            Marker.transform.rotation = Marker12b.transform.rotation;
        }
        if(Tracker == 35){
            Marker.transform.position = Marker13b.transform.position;
            Marker.transform.rotation = Marker13b.transform.rotation;
        }
        if(Tracker == 36){
            Marker.transform.position = Marker14b.transform.position;
            Marker.transform.rotation = Marker14b.transform.rotation;
        }
        if(Tracker == 37){
            Marker.transform.position = Marker15b.transform.position;
            Marker.transform.rotation = Marker15b.transform.rotation;
        }
        if(Tracker == 38){
            Marker.transform.position = Marker16b.transform.position;
            Marker.transform.rotation = Marker16b.transform.rotation;
        }
        if(Tracker == 39){
            Marker.transform.position = Marker17b.transform.position;
            Marker.transform.rotation = Marker17b.transform.rotation;
        }
        if(Tracker == 40){
            Marker.transform.position = Marker18b.transform.position;
            Marker.transform.rotation = Marker18b.transform.rotation;
        }
        if(Tracker == 41){
            Marker.transform.position = Marker19b.transform.position;
            Marker.transform.rotation = Marker19b.transform.rotation;
        }
        if(Tracker == 42){
            Marker.transform.position = Marker20b.transform.position;
            Marker.transform.rotation = Marker20b.transform.rotation;
        }
        if(Tracker == 43){
            Marker.transform.position = Marker21b.transform.position;
            Marker.transform.rotation = Marker21b.transform.rotation;
        }
        if(Tracker == 45){
            Marker.transform.position = Marker22b.transform.position;
            Marker.transform.rotation = Marker22b.transform.rotation;
        }
        if(Tracker == 46){
            Marker.transform.position = Marker23b.transform.position;
            Marker.transform.rotation = Marker23b.transform.rotation;
        }
        if(Input.GetButtonDown ("Autodrive")){
            
            StartCoroutine (AutopilotChange());
        }
    }
    ///<summary>
    /// Methode that detected a collision of player car and tracker and set a correct value of tracker.
    ///</summary>
    IEnumerator OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag == "PlayerCar"){
            this.GetComponent<BoxCollider>().enabled = false;
            Tracker += 1;
            if(Tracker == 23){
                Tracker = 0;
            }
            if(Tracker == 28){
                Tracker=5;
            }
            if(Tracker==33){
                Tracker=16;
            }
            if(Tracker==44){
                Tracker=20;
            }
            if(Tracker==47){
                Tracker=0;
            }
            yield return new WaitForSeconds (0.01f);
            this.GetComponent<BoxCollider> ().enabled = true;
        }
            
        
    }
    ///<summary>
    /// Methode that reset a car in autopilot mode to the position of previous tracker.
    ///</summary>
    IEnumerator ResetAutopilot(){
        yield return new WaitForSeconds (1.0f);
        if(speed<1.0){
            speed=0;
            if(Tracker == 0){
                CarAuto.transform.position = Mark23.transform.position;
                CarAuto.transform.rotation = Mark23.transform.rotation;
            }
            if(Tracker == 1){
                CarAuto.transform.position = Mark01.transform.position;
                CarAuto.transform.rotation = Mark01.transform.rotation;
            }
            if(Tracker == 2){
                CarAuto.transform.position = Mark02.transform.position;
                CarAuto.transform.rotation = Mark02.transform.rotation;
            }
            if(Tracker == 3){
                CarAuto.transform.position = Mark03.transform.position;
                CarAuto.transform.rotation = Mark03.transform.rotation;
            }
            if(Tracker == 4){
                CarAuto.transform.position = Mark04.transform.position;
                CarAuto.transform.rotation = Mark04.transform.rotation;
            }
            if(Tracker == 5){
                CarAuto.transform.position = Mark05.transform.position;
                CarAuto.transform.rotation = Mark05.transform.rotation;
            }
            if(Tracker == 6){
                CarAuto.transform.position = Mark06.transform.position;
                CarAuto.transform.rotation = Mark06.transform.rotation;
            }
            if(Tracker == 7){
                CarAuto.transform.position = Mark07.transform.position;
                CarAuto.transform.rotation = Mark07.transform.rotation;
            }
            if(Tracker == 8){
                CarAuto.transform.position = Mark08.transform.position;
                CarAuto.transform.rotation = Mark08.transform.rotation;
            }
            if(Tracker == 9){
                CarAuto.transform.position = Mark09.transform.position;
                CarAuto.transform.rotation = Mark09.transform.rotation;
            }
            if(Tracker == 10){
                CarAuto.transform.position = Mark10.transform.position;
                CarAuto.transform.rotation = Mark10.transform.rotation;
            }
            if(Tracker == 11){
                CarAuto.transform.position = Mark11.transform.position;
                CarAuto.transform.rotation = Mark11.transform.rotation;
            }
            if(Tracker == 12){
                CarAuto.transform.position = Mark12.transform.position;
                CarAuto.transform.rotation = Mark12.transform.rotation;
            }
            if(Tracker == 13){
                CarAuto.transform.position = Mark13.transform.position;
                CarAuto.transform.rotation = Mark13.transform.rotation;
            }
            if(Tracker == 14){
                CarAuto.transform.position = Mark14.transform.position;
                CarAuto.transform.rotation = Mark14.transform.rotation;
            }
            if(Tracker == 15){
                CarAuto.transform.position = Mark15.transform.position;
                CarAuto.transform.rotation = Mark15.transform.rotation;
            }
            if(Tracker == 16){
                CarAuto.transform.position = Mark16.transform.position;
                CarAuto.transform.rotation = Mark16.transform.rotation;
            }
            if(Tracker == 17){
                CarAuto.transform.position = Mark17.transform.position;
                CarAuto.transform.rotation = Mark17.transform.rotation;
            }
            if(Tracker == 18){
                CarAuto.transform.position = Mark18.transform.position;
                CarAuto.transform.rotation = Mark18.transform.rotation;
            }
            if(Tracker == 19){
                CarAuto.transform.position = Mark19.transform.position;
                CarAuto.transform.rotation = Mark19.transform.rotation;
            }
            if(Tracker == 20){
                CarAuto.transform.position = Mark20.transform.position;
                CarAuto.transform.rotation = Mark20.transform.rotation;
            }
            if(Tracker == 21){
                CarAuto.transform.position = Mark21.transform.position;
                CarAuto.transform.rotation = Mark21.transform.rotation;
            }
            if(Tracker == 22){
                CarAuto.transform.position = Mark22.transform.position;
                CarAuto.transform.rotation = Mark22.transform.rotation;
            }
            if(Tracker == 24){
                CarAuto.transform.position = Marker01b.transform.position;
                CarAuto.transform.rotation = Marker01b.transform.rotation;
            }
            if(Tracker == 25){
                CarAuto.transform.position = Marker02b.transform.position;
                CarAuto.transform.rotation = Marker02b.transform.rotation;
            }
            if(Tracker == 26){
                CarAuto.transform.position = Marker03b.transform.position;
                CarAuto.transform.rotation = Marker03b.transform.rotation;
            }
            if(Tracker == 27){
                CarAuto.transform.position = Marker04b.transform.position;
                CarAuto.transform.rotation = Marker04b.transform.rotation;
            }
            if(Tracker == 29){
                CarAuto.transform.position = Marker07b.transform.position;
                CarAuto.transform.rotation = Marker07b.transform.rotation;
            }
            if(Tracker == 30){
                CarAuto.transform.position = Marker08b.transform.position;
                CarAuto.transform.rotation = Marker08b.transform.rotation;
            }
            if(Tracker == 31){
                CarAuto.transform.position = Marker09b.transform.position;
                CarAuto.transform.rotation = Marker09b.transform.rotation;
            }
            if(Tracker == 32){
                CarAuto.transform.position = Marker10b.transform.position;
                CarAuto.transform.rotation = Marker10b.transform.rotation;
            }
            if(Tracker == 34){
                CarAuto.transform.position = Marker11b.transform.position;
                CarAuto.transform.rotation = Marker11b.transform.rotation;
            }
            if(Tracker == 35){
                CarAuto.transform.position = Marker12b.transform.position;
                CarAuto.transform.rotation = Marker12b.transform.rotation;
            }
            if(Tracker == 36){
                CarAuto.transform.position = Marker13b.transform.position;
                CarAuto.transform.rotation = Marker13b.transform.rotation;
            }
            if(Tracker == 37){
                CarAuto.transform.position = Marker14b.transform.position;
                CarAuto.transform.rotation = Marker14b.transform.rotation;
            }
            if(Tracker == 38){
                CarAuto.transform.position = Marker15b.transform.position;
                CarAuto.transform.rotation = Marker15b.transform.rotation;
            }
            if(Tracker == 39){
                CarAuto.transform.position = Marker16b.transform.position;
                CarAuto.transform.rotation = Marker16b.transform.rotation;
            }
            if(Tracker == 40){
                CarAuto.transform.position = Marker17b.transform.position;
                CarAuto.transform.rotation = Marker17b.transform.rotation;
            }
            if(Tracker == 41){
                CarAuto.transform.position = Marker18b.transform.position;
                CarAuto.transform.rotation = Marker18b.transform.rotation;
            }
            if(Tracker == 42){
                CarAuto.transform.position = Marker19b.transform.position;
                CarAuto.transform.rotation = Marker19b.transform.rotation;
            }
            if(Tracker == 43){
                CarAuto.transform.position = Marker20b.transform.position;
                CarAuto.transform.rotation = Marker20b.transform.rotation;
            }
            if(Tracker == 45){
                CarAuto.transform.position = Marker21b.transform.position;
                CarAuto.transform.rotation = Marker21b.transform.rotation;
            }
            if(Tracker == 46){
                CarAuto.transform.position = Marker22b.transform.position;
                CarAuto.transform.rotation = Marker22b.transform.rotation;
            }  
        }  
    }
    ///<summary>
    /// Methode that turning on and off a autopilot mode and set a car model.
    ///</summary>
    IEnumerator AutopilotChange(){
        yield return new WaitForSeconds (0.01f);
        if(Autopilot==0){
            Autopilot++;
            CarAuto.SetActive(true);
            SkyCarAuto.SetActive(false);
            if(RedBody.activeSelf){
                RedBody.SetActive(false);
                RedBodyPilot.SetActive(true);
            }
            if(BlueBody.activeSelf){
                BlueBody.SetActive(false);
                BlueBodyPilot.SetActive(true);
            }
            if(YellowBody.activeSelf){
                YellowBody.SetActive(false);
                YellowBodyPilot.SetActive(true);
            }
            if(BlackBody.activeSelf){
                BlackBody.SetActive(false);
                BlackBodyPilot.SetActive(true);
            }
            CarAuto.transform.position=CarUser.transform.position;
            CarAuto.transform.rotation=CarUser.transform.rotation;
            CarUser.SetActive(false);
        }
        else{
            Autopilot=0;
            CarUser.SetActive(true);
            if(RedBodyPilot.activeSelf){
                RedBodyPilot.SetActive(false);
                RedBody.SetActive(true);
            }
            if(BlueBodyPilot.activeSelf){
                BlueBodyPilot.SetActive(false);
                BlueBody.SetActive(true);
            }
            if(YellowBodyPilot.activeSelf){
                YellowBodyPilot.SetActive(false);
                YellowBody.SetActive(true);
            }
            if(BlackBodyPilot.activeSelf){
                BlackBodyPilot.SetActive(false);
                BlackBody.SetActive(true);
            }
            CarUser.transform.position=CarAuto.transform.position;
            CarUser.transform.rotation=CarAuto.transform.rotation;
            CarAuto.SetActive(false);
        }  
    }
}