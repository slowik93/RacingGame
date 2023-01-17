using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

///<summary>
/// Class that support a countdown at the beginnig of the race.
///</summary>
public class Countdown : MonoBehaviour
{
    public GameObject CountDown;
    public GameObject LapTimer;
    public GameObject CarControls;
    public GameObject FinalMessage;
    public GameObject StartedBarrier;
    public GameObject Tracker;
    
    ///<summary>
    /// Methode that starts a countdown at the beginning of the race.
    ///</summary>
    void Start()
    {
        CarControls.SetActive(false);
        CheckpointsReset.Tracker=0;
        Autopilot01.Tracker=0;
        Autopilot02.Tracker=0;
        StartCoroutine (CountStart());    
    }
    ///<summary>
    /// Methode that starts a count 3 seconds to start a race.
    ///</summary>
    IEnumerator CountStart () {
        FinalMessage.SetActive(false);
        CarControls.SetActive(false);
        LapTimer.SetActive(false);
        yield return new WaitForSeconds (0.5f);
        CountDown.GetComponent<TMPro.TextMeshProUGUI>().text = "3";
        CountDown.SetActive(true);
        yield return new WaitForSeconds (1);
        CountDown.SetActive(false);
        CountDown.GetComponent<TMPro.TextMeshProUGUI>().text = "2";
        CountDown.SetActive(true);
        yield return new WaitForSeconds (1);
        CountDown.SetActive(false);
        CountDown.GetComponent<TMPro.TextMeshProUGUI>().text = "1";
        CountDown.SetActive(true);
        yield return new WaitForSeconds (1);
        CarController.m_Topspeed=100.0f;
        CountDown.SetActive(false);
        LapTimer.SetActive(true);
        CarControls.SetActive(true);
        StartedBarrier.SetActive(false);
        yield return new WaitForSeconds(1);
        Tracker.SetActive(true);
       

    }
}
