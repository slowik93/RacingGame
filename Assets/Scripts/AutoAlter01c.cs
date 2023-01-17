using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// Class that handle an alternative road for player car in autopilot mode.
///</summary>
public class AutoAlter01c : MonoBehaviour
{
    public GameObject Marker07b;
    public GameObject Marker08b;
    public GameObject Marker09b;
    public GameObject Marker10b;
    public GameObject Marker11b;

    ///<summary>
    /// Methode that activate an alternative track if tracker is set on right value.
    ///</summary>
    void Update()
    {
        if(Autopilot01.Tracker==9){
            Marker07b.SetActive(true);
        }
    }
    ///<summary>
    /// Methode that detected a collision of player car and tracker and set a correct value of tracker.
    ///</summary>
    IEnumerator OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag == "PlayerCar"){
            this.GetComponent<BoxCollider>().enabled = false;
            Autopilot01.Tracker=29;
            Marker07b.SetActive(false);
            yield return new WaitForSeconds (0.01f);
            this.GetComponent<BoxCollider> ().enabled = true;
        }
    }
}
