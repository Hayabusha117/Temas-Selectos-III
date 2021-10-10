using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarMaterial : MonoBehaviour
{
    public GameObject esfera;
    public Material material_1;
    public Material material_2;
    public Material material_3;
    public Material material_4;
   

    int materialCase = 1;

    public void Boton_CambiarMaterial()
    {
        //Bucle para boton
        if(materialCase == 1)
        {
            materialCase = 2;
        }
        else
        {
            if(materialCase == 2)
            {
                materialCase = 3;

            }
            else
            {
                if(materialCase == 3)
                {
                    materialCase = 4;

                }
                else
                {
                    if(materialCase == 4)
                    {
                        materialCase = 1;

                    }
                  
                }
            }
        }

        

        //Cambio de material
        Renderer rend = esfera.GetComponent<Renderer>();
        switch (materialCase)
        {

            case 4:
                rend.material = material_4;
                break;
            case 3:
                rend.material = material_3;
                break;
            case 2:
                rend.material = material_2;
                break;
            case 1:
                rend.material = material_1;
                break;
            default:
                break;
        }
    }

}









   