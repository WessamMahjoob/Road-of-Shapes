using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadly : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
  
    
    private void OnTriggerEnter(Collider other)
    {
        
        PlayerManag.gameOver = true;
        if (PlayerManag.c.GetComponent<MeshRenderer>().enabled == true)
        {
            Destroy(PlayerManag.c);
        }
        else if (PlayerManag.s.GetComponent<MeshRenderer>().enabled == true)
        {
            Destroy(PlayerManag.s);
        }
        else if (PlayerManag.t.GetComponent<MeshRenderer>().enabled == true)
        {
            Destroy(PlayerManag.t);
        }


    }
   
}
