using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuel : Car
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FuelBar = GameObject.FindWithTag("FuelBar").GetComponent<Slider>();
           
            FuelBar.value += 0.01f;
            Destroy(gameObject);

        }
    }
}
