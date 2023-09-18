using UnityEngine;

public class DoorValidator : MonoBehaviour
{
    public int cantidadObjetos;
    [SerializeField] private Transform nextPosition;
    private bool canOpen = true;
    
    private void Update()
    {
        if (cantidadObjetos == 0 && canOpen == true)
        {
            transform.position = Vector3.MoveTowards(transform.position,nextPosition.position, 1 * Time.deltaTime);
    

        }

        if (transform.position == nextPosition.position)
        {
            canOpen = false;
            //Destroy(gameObject);
        }
    }

    public void Restar()
    {
        cantidadObjetos--;
    }
}
