using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentation : MonoBehaviour
{
    [SerializeField] private float speed, speedRotation;

    void Update()
    {
        float movimentacao = (Input.GetAxis("Vertical") * speed) * Time.deltaTime;
        float rotation = (Input.GetAxis("Horizontal") * speedRotation) * Time.deltaTime;

        // transform.Rotate(0, rotation, 0);
        transform.Translate(0, 0 , movimentacao);
        transform.Translate(rotation, 0, 0);
    }
}
