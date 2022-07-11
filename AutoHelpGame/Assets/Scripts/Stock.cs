using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stock : MonoBehaviour
{
   public  GameObject button;
    
    public void PressButton(int scenenumber)
    {
        
        SceneManager.LoadScene(scenenumber);
    }
}
