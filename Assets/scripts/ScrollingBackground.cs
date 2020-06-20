using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
 
    private Renderer renderer;
    public float scrollSpeed = .1f;
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
       
        
        Vector2 offset = new Vector2(x, 0);
        renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}