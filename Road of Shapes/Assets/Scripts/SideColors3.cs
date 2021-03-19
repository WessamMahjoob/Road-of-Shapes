using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideColors3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
            if (PlayerManag.c.GetComponent<MeshRenderer>().enabled == true)
            {
                this.GetComponent<Renderer>().material = PlayerManag.TriangleRed;
            }
            else if (PlayerManag.s.GetComponent<MeshRenderer>().enabled == true)
            {
                this.GetComponent<Renderer>().material = PlayerManag.CircleBlue;
            }
            else if (PlayerManag.t.GetComponent<MeshRenderer>().enabled == true)
            {
                this.GetComponent<Renderer>().material = PlayerManag.SquareGreen;
            }
        
    }
}
