using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>
/// Class that support a situation when players car hit the water.
///</summary>
public class Water : MonoBehaviour
{
    public GameObject LivesText;
    public GameObject CarControl;
    public GameObject FinalMessage;
    public GameObject ReturnButton;
    public GameObject Player;
    public GameObject Checkpoint01;
    public GameObject Checkpoint02;
    public GameObject Checkpoint03;
    public GameObject Checkpoint04;
    public GameObject Checkpoint05;

    ///<summary>
    /// Methode that shows a number of lives on the screen.
    ///</summary>
    void Update()
    {
        LivesText.GetComponent<TMPro.TextMeshProUGUI>().text = CheckpointsReset.Lives + "";
    }
    ///<summary>
    /// Methode that teleport a player car back on track when collision with water will be detected and take one live.
    ///</summary>
    IEnumerator OnTriggerEnter(){
        yield return new WaitForSeconds (0.01f);
        if(CheckpointsReset.Tracker == 0){
            Player.transform.position = Checkpoint05.transform.position;
            Player.transform.rotation = Checkpoint05.transform.rotation;
        }
        if(CheckpointsReset.Tracker == 1){
            Player.transform.position = Checkpoint01.transform.position;
            Player.transform.rotation = Checkpoint01.transform.rotation;
        }
        if(CheckpointsReset.Tracker == 2){
            Player.transform.position = Checkpoint02.transform.position;
            Player.transform.rotation = Checkpoint02.transform.rotation;
        }
        if(CheckpointsReset.Tracker == 3){
            Player.transform.position = Checkpoint03.transform.position;
            Player.transform.rotation = Checkpoint03.transform.rotation;
        }
        if(CheckpointsReset.Tracker == 4){
            Player.transform.position = Checkpoint04.transform.position;
            Player.transform.rotation = Checkpoint04.transform.rotation;
        }
        
        CheckpointsReset.Lives=CheckpointsReset.Lives-1;
        if(CheckpointsReset.Lives==0){
            CarControl.SetActive(false);
            FinalMessage.SetActive(true);
            FinalMessage.GetComponent<TMPro.TextMeshProUGUI>().text = "Out of lives";
            ReturnButton.SetActive(true);
        }
    }
}
