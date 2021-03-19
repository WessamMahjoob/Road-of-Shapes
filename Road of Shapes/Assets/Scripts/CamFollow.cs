using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{

    public Transform target;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.transform.position;
    }



// Update is called once per frame
void Update()
    {
        if (target != null)
        {
            Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, offset.z + target.position.z);
            transform.position = newPosition;
        }
    }
}
