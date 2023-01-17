using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///<summary>
/// Class that handle a road for AI car.
///</summary>
public class AITrack01 : MonoBehaviour
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
    public int Tracker;
    public float Speed;
    public Rigidbody ControlledCar;
    ///<summary>
    /// Methode that set a tracker at started value.
    ///</summary>
    void Start()
    {
        Tracker=0;
    }
    ///<summary>
    /// Methode that change a position of tracker and reset an AI car on the track.
    ///</summary>
    void Update()
    {
        Speed=ControlledCar.velocity.magnitude*3.6f;
        if(Speed<1.0){
            ControlledCar.transform.position = Marker.transform.position;
            ControlledCar.transform.rotation = Marker.transform.rotation;
            Speed=0;
            if(Tracker == 0){
                ControlledCar.transform.position = Mark23.transform.position;
                ControlledCar.transform.rotation = Mark23.transform.rotation;
            }
            if(Tracker == 1){
                ControlledCar.transform.position = Mark01.transform.position;
                ControlledCar.transform.rotation = Mark01.transform.rotation;
            }
            if(Tracker == 2){
                ControlledCar.transform.position = Mark02.transform.position;
                ControlledCar.transform.rotation = Mark02.transform.rotation;
            }
            if(Tracker == 3){
                ControlledCar.transform.position = Mark03.transform.position;
                ControlledCar.transform.rotation = Mark03.transform.rotation;
            }
            if(Tracker == 4){
                ControlledCar.transform.position = Mark04.transform.position;
                ControlledCar.transform.rotation = Mark04.transform.rotation;
            }
            if(Tracker == 5){
                ControlledCar.transform.position = Mark05.transform.position;
                ControlledCar.transform.rotation = Mark05.transform.rotation;
            }
            if(Tracker == 6){
                ControlledCar.transform.position = Mark06.transform.position;
                ControlledCar.transform.rotation = Mark06.transform.rotation;
            }
            if(Tracker == 7){
                ControlledCar.transform.position = Mark07.transform.position;
                ControlledCar.transform.rotation = Mark07.transform.rotation;
            }
            if(Tracker == 8){
                ControlledCar.transform.position = Mark08.transform.position;
                ControlledCar.transform.rotation = Mark08.transform.rotation;
            }
            if(Tracker == 9){
                ControlledCar.transform.position = Mark09.transform.position;
                ControlledCar.transform.rotation = Mark09.transform.rotation;
            }
            if(Tracker == 10){
                ControlledCar.transform.position = Mark10.transform.position;
                ControlledCar.transform.rotation = Mark10.transform.rotation;
            }
            if(Tracker == 11){
                ControlledCar.transform.position = Mark11.transform.position;
                ControlledCar.transform.rotation = Mark11.transform.rotation;
            }
            if(Tracker == 12){
                ControlledCar.transform.position = Mark12.transform.position;
                ControlledCar.transform.rotation = Mark12.transform.rotation;
            }
            if(Tracker == 13){
                ControlledCar.transform.position = Mark13.transform.position;
                ControlledCar.transform.rotation = Mark13.transform.rotation;
            }
            if(Tracker == 14){
                ControlledCar.transform.position = Mark14.transform.position;
                ControlledCar.transform.rotation = Mark14.transform.rotation;
            }
            if(Tracker == 15){
                ControlledCar.transform.position = Mark15.transform.position;
                ControlledCar.transform.rotation = Mark15.transform.rotation;
            }
            if(Tracker == 16){
                ControlledCar.transform.position = Mark16.transform.position;
                ControlledCar.transform.rotation = Mark16.transform.rotation;
            }
            if(Tracker == 17){
                ControlledCar.transform.position = Mark17.transform.position;
                ControlledCar.transform.rotation = Mark17.transform.rotation;
            }
            if(Tracker == 18){
                ControlledCar.transform.position = Mark18.transform.position;
                ControlledCar.transform.rotation = Mark18.transform.rotation;
            }
            if(Tracker == 19){
                ControlledCar.transform.position = Mark19.transform.position;
                ControlledCar.transform.rotation = Mark19.transform.rotation;
            }
            if(Tracker == 20){
                ControlledCar.transform.position = Mark20.transform.position;
                ControlledCar.transform.rotation = Mark20.transform.rotation;
            }
            if(Tracker == 21){
                ControlledCar.transform.position = Mark21.transform.position;
                ControlledCar.transform.rotation = Mark21.transform.rotation;
            }
            if(Tracker == 22){
                ControlledCar.transform.position = Mark22.transform.position;
                ControlledCar.transform.rotation = Mark22.transform.rotation;
            }
        }
        if(Tracker == 0){
            Marker.transform.position = Mark01.transform.position;
        }
        if(Tracker == 1){
            Marker.transform.position = Mark02.transform.position;
        }
        if(Tracker == 2){
            Marker.transform.position = Mark03.transform.position;
        }
        if(Tracker == 3){
            Marker.transform.position = Mark04.transform.position;
        }
        if(Tracker == 4){
            Marker.transform.position = Mark05.transform.position;
        }
        if(Tracker == 5){
            Marker.transform.position = Mark06.transform.position;
        }
        if(Tracker == 6){
            Marker.transform.position = Mark07.transform.position;
        }
        if(Tracker == 7){
            Marker.transform.position = Mark08.transform.position;
        }
        if(Tracker == 8){
            Marker.transform.position = Mark09.transform.position;
        }
        if(Tracker == 9){
            Marker.transform.position = Mark10.transform.position;
        }
        if(Tracker == 10){
            Marker.transform.position = Mark11.transform.position;
        }
        if(Tracker == 11){
            Marker.transform.position = Mark12.transform.position;
        }
        if(Tracker == 12){
            Marker.transform.position = Mark13.transform.position;
        }
        if(Tracker == 13){
            Marker.transform.position = Mark14.transform.position;
        }
        if(Tracker == 14){
            Marker.transform.position = Mark15.transform.position;
        }
        if(Tracker == 15){
            Marker.transform.position = Mark16.transform.position;
        }
        if(Tracker == 16){
            Marker.transform.position = Mark17.transform.position;
        }
        if(Tracker == 17){
            Marker.transform.position = Mark18.transform.position;
        }
        if(Tracker == 18){
            Marker.transform.position = Mark19.transform.position;
        }
        if(Tracker == 19){
            Marker.transform.position = Mark20.transform.position;
        }
        if(Tracker == 20){
            Marker.transform.position = Mark21.transform.position;
        }
        if(Tracker == 21){
            Marker.transform.position = Mark22.transform.position;
        }
        if(Tracker == 22){
            Marker.transform.position = Mark23.transform.position;
        }
        
    }
    ///<summary>
    /// Methode that detected a collision of AI car and tracker and increase a position of tracker.
    ///</summary>
    IEnumerator OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag == "AICar"){
            this.GetComponent<BoxCollider>().enabled = false;
            Tracker += 1;
            if(Tracker == 23){
                Tracker = 0;
            }
            yield return new WaitForSeconds (1);
            this.GetComponent<BoxCollider> ().enabled = true;
        }
    }
}
