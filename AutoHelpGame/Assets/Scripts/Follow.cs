using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - target.position;
    }

}
