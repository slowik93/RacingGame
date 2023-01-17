using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

///<summary>
/// Class that include a system of cash.
///</summary>
public class CashSystem : MonoBehaviour
{
    public int CashValue;
    public static int TotalCash;
    public GameObject Cash;
    
    ///<summary>
    /// Methode that updated cash.
    ///</summary>
    void Update()
    {
        UpdateCash();
    }
    ///<summary>
    /// Methode that shows a player current value of cash.
    ///</summary>
    public void UpdateCash()
    {
        CashValue = TotalCash;
        Cash.GetComponent<TMPro.TextMeshProUGUI>().text = "Cash: " + CashValue + "$";
    }
}
