using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarButtons : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExternalEngineTurnOn(bool forward)
    {
        player.GetComponent<carEngine>().EngineTurnOn(forward);
    }
     public void ExternalBrakesTurnOn()
    {
        player.GetComponent<carEngine>().BrakesTurnOn();
    }
}
