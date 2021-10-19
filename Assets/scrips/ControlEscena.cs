using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //manejo de escenas

public class ControlEscena : MonoBehaviour
{
  //funcion que van a ejecutar los botones
  // recibe como parametro el nombre de la escena formato string
  public void LoadScene(string sceneName)
    {
        //instruccion para hacer la carga de las escenas
        SceneManager.LoadScene(sceneName);
    }
}
