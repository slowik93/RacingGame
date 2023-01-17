using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// Class used to handling an event when AI car reach a halfway.
///</summary>
public class AIHalfPointTrigger : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    // Start is called before the first frame update
    ///<summary>
    /// Methode that detected a collision of AI car and half point trigger.
    ///</summary>
    void OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag == "AICar"){
            LapCompleteTrig.SetActive (true);
            HalfLapTrig.SetActive (false);
        }
    }
}
