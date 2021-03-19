using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float posX=-0.23f; //-0,23
    
    private int playerPosition = 1;
    public static float speed =5f;
   


    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManag.c.gameObject == null || PlayerManag.s.gameObject == null || PlayerManag.t.gameObject == null)
        {
            
        }
        else
        {
            // if D key is pressed down
            if (SwipeManager.swipeRight)
            {
                if (playerPosition < 2)
                {
                    // move the player along the positive Z axis
                    posX = posX + 2;
                    // increment the player position
                    playerPosition++;
                }
            }
            // if A key is pressed down
            else if (SwipeManager.swipeLeft)
            {
                if (playerPosition > 0)
                {
                    // move the player along the negative Z axis
                    posX = posX - 2;
                    // decrement the player position
                    playerPosition--;
                }
            }
        }
        //// if D key is pressed down
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    if (playerPosition < 2)
        //    {
        //        // move the player along the positive Z axis
        //        posX = posX+2;
        //        // increment the player position
        //        playerPosition++;
        //    }
        //}
        //// if A key is pressed down
        //else if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    if (playerPosition > 0)
        //    {
        //        // move the player along the negative Z axis
        //        posX = posX-2;
        //        // decrement the player position
        //        playerPosition--;
        //    }
        //}

        transform.position = Vector3.Lerp(transform.position, new Vector3(posX, transform.position.y, transform.position.z), Time.deltaTime * 10);
    }
    private void FixedUpdate()
    {
        transform.position += Vector3.forward * Time.deltaTime * speed;
    }

  
}
