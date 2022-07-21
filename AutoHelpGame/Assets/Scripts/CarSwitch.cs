using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSwitch : MonoBehaviour
{
    public void BuggySelected()
    {
        PlayerDataHub.instance.PlayerData.SelectCar(0);
    }

    public void PrioraSelected()
    {
        PlayerDataHub.instance.PlayerData.SelectCar(2);
    }

    public void RedVazSelected()
    {
        PlayerDataHub.instance.PlayerData.SelectCar(1);
    }

    public void SupraSelected()
    {
        PlayerDataHub.instance.PlayerData.SelectCar(3);
    }
}
