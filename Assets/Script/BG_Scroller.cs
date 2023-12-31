using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Scroller : MonoBehaviour
{
    public float scrollSpeed;

    private Vector3 starPosition;
    private float tileSize;
    // Start is called before the first frame update
    void Start()
    {
        starPosition = transform.position;
        tileSize = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSize);
        transform.position = starPosition + Vector3.forward * newPosition;
    }
}
