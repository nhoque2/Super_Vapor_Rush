using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
   //BEGIN code by me (Ashton Sims)
    // Update is called once per frame
    void Update()
    {
      
    }

    public void Quit()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }
    //END code by me (Ashton Sims)
}
