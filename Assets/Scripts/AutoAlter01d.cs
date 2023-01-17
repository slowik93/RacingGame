using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// Class that handle an alternative road for player car in autopilot mode.
///</summary>
public class AutoAlter01d : MonoBehaviour
{
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
    
    ///<summary>
    /// Methode that activate an alternative track if tracker is set on right value.
    ///</summary>
    void Update()
    {
        if(Autopilot01.Tracker==16){
            Marker12b.SetActive(true);
        }
    }
    ///<summary>
    /// Methode that detected a collision of player car and tracker and set a correct value of tracker.
    ///</summary>
    IEnumerator OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag == "PlayerCar"){
            this.GetComponent<BoxCollider>().enabled = false;
            Autopilot01.Tracker=34;
            Marker12b.SetActive(false);
            yield return new WaitForSeconds (0.01f);
            this.GetComponent<BoxCollider> ().enabled = true;
        }
    }
}
