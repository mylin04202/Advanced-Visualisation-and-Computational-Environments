using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + "touch me");
        if (other.name == "player")
        {
            Time.timeScale = 0;
        }
  
    }
}
