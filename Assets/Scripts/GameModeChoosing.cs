using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///<summary>
/// Class that support a game mode chosen by player.
///</summary>
public class GameModeChoosing : MonoBehaviour
{
    public static int GameMode;
    public GameObject TrackWindow;

    ///<summary>
    /// Methode that set a race mode in game.
    ///</summary>
    public void RaceMode(){
        GameMode = 1;
        TrackWindow.SetActive(true);
    }
    ///<summary>
    /// Methode that set a time attack mode in game.
    ///</summary>
    public void TimeMode(){
        GameMode = 2;
        TrackWindow.SetActive(true);
    }
}
