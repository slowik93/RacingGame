using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// Class that support a setting button in main menu.
///</summary>
public class SettingButtion : MonoBehaviour
{
    public GameObject Volume;

    ///<summary>
    /// Methode that activate a settings panel.
    ///</summary>
    public void VolumeOn(){
        Volume.SetActive(true);
    }
}
