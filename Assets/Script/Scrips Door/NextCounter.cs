using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextCounter : MonoBehaviour
{
    public GameObject Particle;
    // Start is called before the first frame update
    void Start()
    {
        Particle.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.childCount == 0) 
        
        { Particle.gameObject.SetActive(true); }
    }
}
