using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateTexture : MonoBehaviour
{
    
     float ScrollY = -0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float OffsetX = 0;
        float OffsetY = Time.time * ScrollY;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(OffsetX, OffsetY);
    }
}
