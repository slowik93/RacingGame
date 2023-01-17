using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

///<summary>
/// Class that show a best lap time on a screen.
///</summary>
public class LapBestTime : MonoBehaviour
{
    public int MinCount;
    public int SecCount;
    public float MilCount;
    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilDisplay;

    ///<summary>
    /// Methode that starts a main methode of class.
    ///</summary>
    void Start()
    {
        DownloadBestLap();
    }

    ///<summary>
    /// Methode that set a fastest lap in game on screen and show a best lap on screen.
    ///</summary>
    public void DownloadBestLap()
    {
        MinCount = PlayerPrefs.GetInt ("MinSave");
        SecCount = PlayerPrefs.GetInt ("SecSave");
        MilCount = PlayerPrefs.GetFloat ("MilliSave");

        MinDisplay.GetComponent<TMPro.TextMeshProUGUI> ().text = "" + MinCount + ":";
        SecDisplay.GetComponent<TMPro.TextMeshProUGUI> ().text = "" + SecCount + ".";
        MilDisplay.GetComponent<TMPro.TextMeshProUGUI> ().text = "" + MilCount.ToString("F0");
    }

   
}
