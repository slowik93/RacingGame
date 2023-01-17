using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// Class that handle an alternative road for player car in autopilot mode.
///</summary>
public class AutoAlter01e : MonoBehaviour
{
    public GameObject Marker22b;
    public GameObject Marker23b;
    
    ///<summary>
    /// Methode that activate an alternative track if tracker is set on right value.
    ///</summary>
    void Update()
    {
        if(Autopilot01.Tracker==20){
            Marker22b.SetActive(true);
        }  
    }
    ///<summary>
    /// Methode that detected a collision of player car and tracker and set a correct value of tracker.
    ///</summary>
    IEnumerator OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag == "PlayerCar"){
            this.GetComponent<BoxCollider>().enabled = false;
            Autopilot01.Tracker=45;
            Marker22b.SetActive(false);
            yield return new WaitForSeconds (0.01f);
            this.GetComponent<BoxCollider> ().enabled = true;
        }
    }
}
