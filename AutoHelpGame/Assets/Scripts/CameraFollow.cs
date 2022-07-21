using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraFollow : MonoBehaviour
{
    public GameObject tPlayer;
    public Transform tFollowTarget;
    private CinemachineVirtualCamera vcam;

    // Start is called before the first frame update
    void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(tPlayer == null)
        {
            tPlayer = GameObject.FindWithTag("Player");
            if(tPlayer != null)
            {
                tFollowTarget = tPlayer.transform;
                vcam.Follow = tFollowTarget;
            }
        }
    }
}
