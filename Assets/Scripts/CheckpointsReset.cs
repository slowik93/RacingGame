using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

///<summary>
/// Class that control a mechanic of checkpoints.
///</summary>
public class CheckpointsReset : MonoBehaviour
{
    public GameObject Player;
    public GameObject Checkpoint01;
    public GameObject Checkpoint02;
    public GameObject Checkpoint03;
    public GameObject Checkpoint04;
    public GameObject Checkpoint05;
    public GameObject Marker;
    public static int Tracker;
    public int IsStarting;
    public Rigidbody CarSpeed;
    public float speed;
    public static int Lives;
    public GameObject LivesText;
    public GameObject CarControl;
    public GameObject FinalMessage;
    public GameObject ReturnButton;
    public GameObject LapTrigger;

    ///<summary>
    /// Methode that sets a number of lives on 3.
    ///</summary>
    void Start()
    {
        Lives = 3;
    }

    ///<summary>
    /// Methode that change a position of active checkpoint.
    ///</summary>
    void Update()
    {
        speed=CarSpeed.velocity.magnitude*3.6f;
        if(Tracker == 0){
            Marker.transform.position = Checkpoint01.transform.position;
            Marker.transform.rotation = Checkpoint01.transform.rotation;       
        }
        if(Tracker == 1){
            Marker.transform.position = Checkpoint02.transform.position;
            Marker.transform.rotation = Checkpoint02.transform.rotation;
        }
        if(Tracker == 2){
            Marker.transform.position = Checkpoint03.transform.position;
            Marker.transform.rotation = Checkpoint03.transform.rotation;
        }
        if(Tracker == 3){
            Marker.transform.position = Checkpoint04.transform.position;
            Marker.transform.rotation = Checkpoint04.transform.rotation;
        }
        if(Tracker == 4){
            Marker.transform.position = Checkpoint05.transform.position;
            Marker.transform.rotation = Checkpoint05.transform.rotation;
            LapTrigger.SetActive(true);
        }
        if(Input.GetButtonDown ("ResetPlayer")){
            
            StartCoroutine (CheckpointChange());
        }
        LivesText.GetComponent<TMPro.TextMeshProUGUI>().text = Lives + "";
    }
    ///<summary>
    /// Methode that detected a collision of player car and tracker and set a correct value of tracker.
    ///</summary>
    IEnumerator OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag == "PlayerCar"){
            this.GetComponent<BoxCollider>().enabled = false;
            Tracker += 1;
            if(Tracker == 5){
                Tracker = 0;
            }
            yield return new WaitForSeconds (1);
            this.GetComponent<BoxCollider> ().enabled = true;
        }
    }
    ///<summary>
    /// Methode that reset a player car back on track and take one live.
    ///</summary>
    IEnumerator CheckpointChange(){
        yield return new WaitForSeconds (0.01f);
        if(Tracker == 0){
            Player.transform.position = Checkpoint05.transform.position;
            Player.transform.rotation = Checkpoint05.transform.rotation;
        }
        if(Tracker == 1){
            Player.transform.position = Checkpoint01.transform.position;
            Player.transform.rotation = Checkpoint01.transform.rotation;
        }
        if(Tracker == 2){
            Player.transform.position = Checkpoint02.transform.position;
            Player.transform.rotation = Checkpoint02.transform.rotation;
        }
        if(Tracker == 3){
            Player.transform.position = Checkpoint03.transform.position;
            Player.transform.rotation = Checkpoint03.transform.rotation;
        }
        if(Tracker == 4){
            Player.transform.position = Checkpoint04.transform.position;
            Player.transform.rotation = Checkpoint04.transform.rotation;
        }
        speed = 0;
        Lives=Lives-1;
        if(Lives<0){
            Lives=0;
        }
        if(Lives==0){
            CarController.m_Topspeed=0.0f;            
            FinalMessage.SetActive(true);
            FinalMessage.GetComponent<TMPro.TextMeshProUGUI>().text = "Out of lives";
            ReturnButton.SetActive(true);
        }
    }
}
