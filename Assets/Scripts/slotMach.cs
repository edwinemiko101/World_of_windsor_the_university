using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class slotMach : MonoBehaviour
{

public void OnTriggerEnter2D(Collider2D collision)   {

        if (collision.gameObject.name == "Player")
        {
           
          SceneManager.LoadScene("RNG");
        }
    }
 
   
}
