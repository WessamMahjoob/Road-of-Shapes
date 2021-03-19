using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gems2 : MonoBehaviour
{
    
  
    bool lol = false;
    // Start is called before the first frame update
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 80 * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (PlayerManag.c.gameObject == null || PlayerManag.s.gameObject == null || PlayerManag.t.gameObject == null)
        {

        }
        else
        {
            if ((other.GetComponent<MeshRenderer>().enabled == true) && (this.gameObject.GetComponent<Renderer>().material.color == other.GetComponent<Renderer>().material.color))
            {
                Destroy(gameObject);
                if (lol == false)
                {

                    PlayerManag.Gems += 3;
                    FindObjectOfType<Sounds>().GemCollecting();
                }
                lol = true;

            }
           
            else if ((PlayerManag.c.GetComponent<MeshRenderer>().enabled == true) && (this.gameObject.GetComponent<Renderer>().material.color != PlayerManag.c.GetComponent<Renderer>().material.color))
            {
                PlayerManag.gameOver = true;
                Destroy(PlayerManag.c);

            }
            else if ((PlayerManag.s.GetComponent<MeshRenderer>().enabled == true) && (this.gameObject.GetComponent<Renderer>().material.color != PlayerManag.s.GetComponent<Renderer>().material.color))
            {
                PlayerManag.gameOver = true;
                Destroy(PlayerManag.s);

            }
            else if ((PlayerManag.t.GetComponent<MeshRenderer>().enabled == true) && (this.gameObject.GetComponent<Renderer>().material.color != PlayerManag.t.GetComponent<Renderer>().material.color))
            {
                PlayerManag.gameOver = true;
                Destroy(PlayerManag.t);

            }
        }
    }
}
