using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

///<summary>
/// Class that support a scenes.
///</summary>
public class ScenesObject : MonoBehaviour
{
    ///<summary>
    /// Methode that load a main menu scene.
    ///</summary>
    public void MainMenu(){
       SceneManager.LoadScene(0);
    }
    ///<summary>
    /// Methode that load a select track scene.
    ///</summary>
    public void PlayGame(){
        SceneManager.LoadScene(1);
    }
    ///<summary>
    /// Methode that load a first track scene.
    ///</summary>
    public void Track1(){
        SceneManager.LoadScene(2);
    }
    ///<summary>
    /// Methode that load a second track scene.
    ///</summary>
    public void Track2(){
        SceneManager.LoadScene(3);
    }
    ///<summary>
    /// Methode that add a cash to player.
    ///</summary>
    public void Reward(){
        CashSystem.TotalCash+=150;
    }
    ///<summary>
    /// Methode that quits a game.
    ///</summary>
    public void QuitGame(){
        Application.Quit();
    }
}
