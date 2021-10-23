using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMov : MonoBehaviour
{

    float speed = 35f;
   
    
    // Start is called before the first frame update
    

    public void Muevete()
    {
        Vector3 movementInput = Vector3.zero;
        movementInput.x = -1;
        move(movementInput);
    }

    public void atras()
    {
        Vector3 movementInput = Vector3.zero;
        movementInput.x = 1;
        move(movementInput);
    }

    public void derecha()
    {
        Vector3 movementInput = Vector3.zero;
        movementInput.z = 1;
        move(movementInput);
    }

    public void izquierda()
    {
        Vector3 movementInput = Vector3.zero;
        movementInput.z = -1;
        move(movementInput);
    }


    void move(Vector3 dir)
    {
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

}
