using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public СarPrefabBus carPrefabBus;
    public PlayerData player;
    public AccelChange accel;
    public BrakesChange brakes;

    void Awake()
    {
        var currentCar = Instantiate(carPrefabBus.FindPrefab(player.TotalCar));
        var carEngine = currentCar.GetComponent<carEngine>();
        accel.pointerUp += carEngine.EngineTurnOn;
        accel.pointerDown += carEngine.EngineTurnOn;
        brakes.pointerUp += carEngine.BrakesTurnOn;
        brakes.pointerDown += carEngine.BrakesTurnOn;
    }
}
