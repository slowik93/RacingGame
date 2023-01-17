using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
/// Class that control a camera settings.
///</summary>
public class ChangingCam : MonoBehaviour
{
    public GameObject MainCam;
    public GameObject FPSCam;
    public GameObject BackCam;
    public GameObject Canvas;
    public int CamMode;
    ///<summary>
    /// Methode that change a position of active camera.
    ///</summary>
    void Update()
    {
        if(Input.GetButtonDown ("ViewMode")){
            if(CamMode == 3){
                CamMode = 0;
            }
            else{
                CamMode += 1;
            }
            StartCoroutine (ModeChange());
        }
    }
    ///<summary>
    /// Methode that changing a camera.
    ///</summary>
    IEnumerator ModeChange(){
        yield return new WaitForSeconds (0.01f);
        if(CamMode == 0){
            MainCam.SetActive(false);
            FPSCam.SetActive(false);
            BackCam.SetActive(true);
            Canvas.SetActive(false);
        }
        if(CamMode == 1){
            FPSCam.SetActive(true);
            MainCam.SetActive(false);
            BackCam.SetActive(false);
            Canvas.SetActive(true);
        }
        if(CamMode == 2){
            FPSCam.SetActive(false);
            MainCam.SetActive(true);
            BackCam.SetActive(false);
            Canvas.SetActive(true);
        }
    }
}
