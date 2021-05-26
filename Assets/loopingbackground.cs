using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopingbackground : MonoBehaviour
{
    public float backgroundspeed;
    public Renderer backgroundrenderer;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        backgroundrenderer.material.mainTextureOffset += new Vector2(backgroundspeed * Time.deltaTime, 0f);
    }
}
