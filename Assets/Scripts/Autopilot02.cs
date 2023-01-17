using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// Class that handle a road for player car in autopilot mode.
///</summary>
public class Autopilot02 : MonoBehaviour
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
    public GameObject Mark03b;
    public GameObject Mark04b;
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
            StartCoroutine(AutopilotBack());
        }
        }
        if(Tracker == 0){
            Marker.transform.position = Mark01.transform.position;
            Marker.transform.rotation = Mark01.transform.rotation;
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
        if(Tracker == 17){
            Marker.transform.position = Mark04b.transform.position;
            Marker.transform.rotation = Mark04b.transform.rotation;
        }
        if(Input.GetButtonDown ("Autodrive")){
            
            StartCoroutine (AutopilotChange());
        }
    }
    ///<summary>
    /// Methode that detected a collision of player car and tracker and set a right value of tracker.
    ///</summary>
    IEnumerator OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag == "PlayerCar"){
            this.GetComponent<BoxCollider>().enabled = false;
            Tracker += 1;
            if(Tracker == 16){
                Tracker = 0;
            }
            if(Tracker == 18){
                Tracker = 9;
            }
            yield return new WaitForSeconds (0.01f);
            this.GetComponent<BoxCollider> ().enabled = true;
        }
            
        
    }
    ///<summary>
    /// Methode that reset a car in autopilot mode to the position of previous tracker.
    ///</summary>
    IEnumerator AutopilotBack(){
        yield return new WaitForSeconds (1.0f);
        if(speed<1.0){
            speed=0;
            if(Tracker == 0){
                CarAuto.transform.position = Mark16.transform.position;
                CarAuto.transform.rotation = Mark16.transform.rotation;
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
            if(Tracker == 17){
                CarAuto.transform.position = Mark03b.transform.position;
                CarAuto.transform.rotation = Mark03b.transform.rotation;
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
