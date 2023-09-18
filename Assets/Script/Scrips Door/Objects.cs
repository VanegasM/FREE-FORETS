using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Objects : MonoBehaviour
{
    [SerializeField] private GameObject door;

  
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            door.GetComponent<DoorValidator>().Restar();
            Destroy(gameObject);
 
        }


    }
}
