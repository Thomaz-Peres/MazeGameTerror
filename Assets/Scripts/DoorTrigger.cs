using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] GameObject door;
    public bool isOpen = false;
    void OnTriggerEnter(Collider col)
    {
        if(!isOpen)
        {
            isOpen = true;
            door.transform.position += new Vector3(0, 78, 0);
            transform.position += new Vector3(0, -2.5f, 0);
        }
        
    }
}
