using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePS : MonoBehaviour
{
    ParticleSystem ps;
    Gradient grad = new Gradient();
    // Start is called before the first frame update
    void Start()
    {
       ps= GetComponent<ParticleSystem>();



    }

    // Update is called once per frame
    void Update()
    {
        
        var col = ps.colorOverLifetime;
        col.enabled = true;
       

        if (PlayerManag.color == "Blue")
            grad.SetKeys(new GradientColorKey[] { new GradientColorKey(Color.cyan, 0.0f), new GradientColorKey(Color.grey, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) });
        else if (PlayerManag.color == "Green")
            grad.SetKeys(new GradientColorKey[] { new GradientColorKey(Color.green, 0.0f), new GradientColorKey(Color.magenta, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) });
        else if (PlayerManag.color == "Red")
            grad.SetKeys(new GradientColorKey[] { new GradientColorKey(Color.red, 0.0f), new GradientColorKey(Color.gray, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) });

        col.color = grad;
        if (PlayerManag.c.gameObject == null || PlayerManag.s.gameObject == null|| PlayerManag.t.gameObject == null) {
            Destroy(this.gameObject);
        }
    }
}
