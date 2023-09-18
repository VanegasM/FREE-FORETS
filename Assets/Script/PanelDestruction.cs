using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelDestruction : MonoBehaviour
{
    public float panelLife = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, panelLife);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
