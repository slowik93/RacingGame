using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

///<summary>
/// Class that support a display of lap time on screen.
///</summary>
public class LapTimeManager : MonoBehaviour
{
    public static int Minute;
    public static int Second;
    public static float Milli;
    public static string MilliDisplay;
    
    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;
    public static float RawTime;
    
    ///<summary>
    /// Methode that starts a main methode of displaying a lap time on the screen.
    ///</summary>
    void Update()
    {
        LapTimer();
    }
    ///<summary>
    /// Methode that display a lap time on screen.
    ///</summary>
    public void LapTimer()
    {
        Milli += Time.deltaTime * 10;
        RawTime += Time.deltaTime;
        if (Milli>=10){
            Milli=0;
            Second+=1;
        }
        MilliDisplay = Mathf.Floor(Milli).ToString ("F0");
        MilliBox.GetComponent<TMPro.TextMeshProUGUI> ().text = "" + MilliDisplay;
        
        if(Second <= 9){
            SecondBox.GetComponent<TMPro.TextMeshProUGUI> ().text = "0" + Second + ".";
        }
        else{
            SecondBox.GetComponent<TMPro.TextMeshProUGUI> ().text = "" + Second + ".";
        }
        if(Second >= 60){
            Second = 0;
            Minute += 1;
        }
        if(Minute <= 9){
            MinuteBox.GetComponent<TMPro.TextMeshProUGUI> ().text = "0" + Minute + ":";
        }
        else{
            MinuteBox.GetComponent<TMPro.TextMeshProUGUI> ().text = "" + Minute + ":";
        }
    }
}
