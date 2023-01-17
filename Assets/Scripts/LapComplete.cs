using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

///<summary>
/// Class that support a mechanic of finishing lap.
///</summary>
public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrigger;
    public GameObject HalfLapTrigger;
    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilDisplay;
    public GameObject LapTimeBox;
    public GameObject CounterLaps;
    public GameObject RaceFinish;
    public int LapsFinished;
    public float RawTime;

    ///<summary>
    /// Methode that set a number of finished laps on 1.
    ///</summary>
    void Start(){
        LapsFinished=1;
    }

    ///<summary>
    /// Methode that active a situation of finishing race if player is on the last lap.
    ///</summary>
    void Update(){
        if(LapsFinished == 3){
            RaceFinish.SetActive(true);
        }
    }
    ///<summary>
    /// Methode that detected a collision of player car and lap complete trigger and reset a current lap time.
    ///</summary>
    void OnTriggerEnter (Collider collision){
        if(collision.gameObject.tag == "PlayerCar"){
        LapsFinished += 1;
        RawTime = PlayerPrefs.GetFloat ("RawTime");
        if(LapTimeManager.RawTime <= RawTime){
            if(LapTimeManager.Second <= 9){
                SecondDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "0" + LapTimeManager.Second + ".";
            }
            else{
                SecondDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + LapTimeManager.Second + ".";
            }

            if(LapTimeManager.Minute <= 9){
                MinuteDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "0" + LapTimeManager.Minute + ".";
            }
            else{
                MinuteDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + LapTimeManager.Minute + ".";
            }
            MilDisplay.GetComponent<TMPro.TextMeshProUGUI> ().text = "" + LapTimeManager.Milli.ToString("F0");
        }
        PlayerPrefs.SetInt("MinSave", LapTimeManager.Minute);
        PlayerPrefs.SetInt("SecSave", LapTimeManager.Second);
        PlayerPrefs.SetFloat("MilliSave", LapTimeManager.Milli);
        PlayerPrefs.SetFloat ("RawTime", LapTimeManager.RawTime);

        LapTimeManager.Minute = 0;
        LapTimeManager.Second = 0;
        LapTimeManager.Milli = 0;
        LapTimeManager.RawTime = 0;

        LapCompleteTrigger.SetActive (false);
        CounterLaps.GetComponent<TMPro.TextMeshProUGUI> ().text = "" + LapsFinished + " / ";
        }
    }
}
