
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideColors1 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerManag.s.gameObject != null && PlayerManag.c.gameObject!=null && PlayerManag.t.gameObject != null)
        {
            if (PlayerManag.c.GetComponent<MeshRenderer>().enabled == true)
            this.GetComponent<Renderer>().material = PlayerManag.c.GetComponent<Renderer>().material;
            else if (PlayerManag.s.GetComponent<MeshRenderer>().enabled == true)
                this.GetComponent<Renderer>().material = PlayerManag.s.GetComponent<Renderer>().material;
            else if (PlayerManag.t.GetComponent<MeshRenderer>().enabled == true)
                this.GetComponent<Renderer>().material = PlayerManag.t.GetComponent<Renderer>().material;
        }
        
    }
}
