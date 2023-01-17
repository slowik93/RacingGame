using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// Class that support a speedometer of player car.
///</summary>
public class Speedometer : MonoBehaviour
{
    public Rigidbody Car;
    public Rigidbody CarAutopilot;
    public GameObject SpeedLabel;
    public float speed;
    public float speedAutopilot;
    
    ///<summary>
    /// Methode that active a main methode of displaying a speedometer.
    ///</summary>
    void Update()
    {
        Speed2();
    }
    ///<summary>
    /// Methode that display a speed of player car.
    ///</summary>
    public void Speed2()
    {   
        if(Autopilot02.Autopilot==0){
            speed=Car.velocity.magnitude*3.6f;
            if(SpeedLabel!=null){
                SpeedLabel.GetComponent<TMPro.TextMeshProUGUI>().text=((int)speed)+" km/h";
            }
        }
        if(Autopilot02.Autopilot==1){
            speedAutopilot=CarAutopilot.velocity.magnitude*3.6f;
            if(SpeedLabel!=null){
                SpeedLabel.GetComponent<TMPro.TextMeshProUGUI>().text=((int)speedAutopilot)+" km/h";
            }
        }
    }
}