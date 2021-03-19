using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    private MeshRenderer mesh;
    [SerializeField] [Range(0f, 1f)] float lerpTime =0;
    [SerializeField] Color[] myColor =null;
    int colorIndex = 0;
    float t = 0f;
    int len;
    float f = 1f;
    Color color;
    bool lol = false;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        len = myColor.Length;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        mesh.material.color = Color.Lerp(mesh.material.color,myColor[colorIndex],lerpTime*Time.deltaTime);
         color = gameObject.GetComponent<MeshRenderer>().material.color;
        
        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
        transform.Rotate(0, 0, 100 * Time.deltaTime);
        if (t > .9f)
        {
            t = 0f;
            colorIndex++;
            colorIndex = (colorIndex >= len ? 0 : colorIndex);
            gameObject.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", color * f);
        }
        
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (lol == false)
        {
            FindObjectOfType<Sounds>().GemCollecting();
            PlayerManag.Gems += 50;
        }
        lol = true;
        Destroy(gameObject);
         
    }
}
