using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch1 : MonoBehaviour
{
    public static int random;

 
    
    // Start is called before the first frame update
    void Start()
    {
        
        random = Random.Range(0, 3);
       
        
        



    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerManag.t.GetComponent<Renderer>().material = PlayerManag.TriangleRed;
        PlayerManag.c.GetComponent<Renderer>().material = PlayerManag.CircleBlue;
        PlayerManag.s.GetComponent<Renderer>().material = PlayerManag.SquareGreen;
        if (random == 0)
        {
            PlayerManag.color = "Blue";
            PlayerManag.c.GetComponent<MeshRenderer>().enabled = true;

            PlayerManag.s.GetComponent<MeshRenderer>().enabled = false;

            PlayerManag.t.GetComponent<MeshRenderer>().enabled = false;
            PlayerController.speed += 0.1f;
            random = Random.Range(0, 3);
            Destroy(gameObject);
        }
        else if (random == 1)
        {
            PlayerManag.color = "Green";
            PlayerManag.c.GetComponent<MeshRenderer>().enabled = false;

            PlayerManag.s.GetComponent<MeshRenderer>().enabled = true;

            PlayerManag.t.GetComponent<MeshRenderer>().enabled = false;
            PlayerController.speed += 0.1f;
            random = Random.Range(0, 3);
            Destroy(gameObject);

        }
        else if (random == 2)
        {
            PlayerManag.color = "Red";
            PlayerManag.c.GetComponent<MeshRenderer>().enabled = false;

            PlayerManag.s.GetComponent<MeshRenderer>().enabled = false;
            PlayerManag.t.GetComponent<MeshRenderer>().enabled = true;
            PlayerController.speed += 0.1f;
            random = Random.Range(0, 3);

            Destroy(gameObject);
        }

    }
    
}
