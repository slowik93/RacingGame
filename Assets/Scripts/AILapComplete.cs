using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// Class used to handling an event when AI car reach a full lap of track.
///</summary>
public class AILapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public GameObject RaceFinish;
    public int LapsFinished;
    ///<summary>
    /// Methode that set number of laps on zero.
    ///</summary>
    void Start()
    {
        LapsFinished = 0;
    }

    ///<summary>
    /// Methode that check if the AICar reach final lap.
    ///</summary>
    void Update()
    {
        if(LapsFinished == 2){
            RaceFinish.SetActive(true);
        }
    }
    ///<summary>
    /// Methode that detected a collision of AI car and lap complete trigger.
    ///</summary>
    void OnTriggerEnter (Collider collision){
        if(collision.gameObject.tag == "AICar"){
            LapsFinished += 1;
        }
        HalfLapTrig.SetActive (true);
        LapCompleteTrig.SetActive (false);
    }
}
