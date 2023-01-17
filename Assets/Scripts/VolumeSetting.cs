using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>
/// Class that support a level of volume.
///</summary>
public class VolumeSetting : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    ///<summary>
    /// Methode that loads a level of volume in the game.
    ///</summary>
    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume")){
            PlayerPrefs.SetFloat("musicVolume",1);
            Load();
        }
        else{
            Load();
        }
    }

    ///<summary>
    /// Methode that change a value of volume.
    ///</summary>
    public void ChangeVolume(){
        AudioListener.volume = volumeSlider.value;
        Save();
    }
    ///<summary>
    /// Methode that load a value of volume in game.
    ///</summary>
    private void Load(){
        volumeSlider.value=PlayerPrefs.GetFloat("musicVolume");
    }
    ///<summary>
    /// Methode that save a value of volume in game.
    ///</summary>
    private void Save(){
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
