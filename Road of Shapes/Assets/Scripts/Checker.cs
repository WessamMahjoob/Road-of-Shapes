using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Checker : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (PlayerManag.c.gameObject == null || PlayerManag.s.gameObject == null || PlayerManag.t.gameObject == null)
        {

        }
        else
        {
            if (PlayerManag.c.GetComponent<MeshRenderer>().enabled == true)
            {
                if (this.gameObject.GetComponent<Renderer>().material.color == PlayerManag.c.GetComponent<Renderer>().material.color)
                {



                }
                else
                {
                    PlayerManag.gameOver = true;
                    Destroy(PlayerManag.c.gameObject);


                }
            }
            else if (PlayerManag.s.GetComponent<MeshRenderer>().enabled == true)
            {
                if (this.gameObject.GetComponent<Renderer>().material.color == PlayerManag.s.GetComponent<Renderer>().material.color)
                {

                }
                else
                {
                    PlayerManag.gameOver = true;

                    Destroy(PlayerManag.s.gameObject);

                }

            }
            else if (PlayerManag.t.GetComponent<MeshRenderer>().enabled == true)
            {
                if (this.gameObject.GetComponent<Renderer>().material.color == PlayerManag.t.GetComponent<Renderer>().material.color)
                {

                }
                else
                {
                    PlayerManag.gameOver = true;


                    Destroy(PlayerManag.t.gameObject);
                }

            }
            else
            {
                PlayerManag.gameOver = true;

            }


        }
    }
}
