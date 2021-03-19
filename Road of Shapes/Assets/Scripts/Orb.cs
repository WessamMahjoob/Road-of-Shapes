using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{

    
    int random;
    int multiScore=2;
    Color green = Color.green;
    Color yellow = Color.yellow;
    Color red = Color.red;
    float f = 1f;
    bool lol = false;


    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(0, 3);
        if (random == 0)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            gameObject.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", green * f);

        }
        else if (random == 1)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
            gameObject.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", yellow * f);

        }
        else if (random == 2)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", red * f);
        }
    }

    // Update is called once per frame
    void Update() 
        {
        transform.Rotate(0, 0, 80 * Time.deltaTime);
       

    }
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<Sounds>().GemCollecting();
        if (random == 0)
        {

            PlayerController.speed -= 0.5f;
            Destroy(gameObject);

        }
        else if (random == 1)
        {
            if (lol == false)
            {
                PlayerManag.Gems += 25;
            }
            lol = true;

            
            Destroy(gameObject);
        }
        else if (random == 2)
        {
            
            StartCoroutine(mulScore());
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }








    }
   
    IEnumerator mulScore()
    {
        PlayerManag.ScorePerSecond *= multiScore;
        yield return new WaitForSeconds(5);
        PlayerManag.ScorePerSecond /= multiScore;
        Destroy(gameObject);
    }
}


