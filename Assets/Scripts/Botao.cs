using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao : MonoBehaviour
{
    public Light luz;
    bool mouseClick;
    public GameObject parede;
    void Start()
    {
        mouseClick = false;
    }

    void Update()
    {
        if(mouseClick == true)
        {
            if (Input.GetMouseButton(0))
            {
                luz.enabled = !luz.enabled;
            }
            Destroy(parede);
        }
    }

    void OnMouseDown()
    {
        mouseClick = true;
    }

    void OnMouseExit()
    {
        mouseClick = false;
    }
}