using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void StartGame() 
    {
        Application.LoadLevel("SampleScene");
    }
    public void LoadRepairMenu()
    {
        Application.LoadLevel("RepairMenu");
    }
    public void LoadCarWashMenu()
    {
        Application.LoadLevel("CarWashMenu");
    }
    public void LoadSalesMenu()
    {
        Application.LoadLevel("SalesMenu");
    }
    public void LoadUpgradeMenu()
    {
        Application.LoadLevel("UpgradeMenu");
    }
}
