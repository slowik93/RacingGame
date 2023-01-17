using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>
/// Class that load a game mode in gameplay.
///</summary>
public class ModeInGame : MonoBehaviour
{
    public int ModeSelected;
    public GameObject AICar;
    
    ///<summary>
    /// Methode that delete a AI car in time attack mode.
    ///</summary>
    void Start()
    {
        ModeSelected = GameModeChoosing.GameMode;
        if(ModeSelected == 2){
            AICar.SetActive(false);
        }
    }
}
