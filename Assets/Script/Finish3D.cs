using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish3D : MonoBehaviour
{
    public int tagScene = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(tagScene);
        }

    }
}
