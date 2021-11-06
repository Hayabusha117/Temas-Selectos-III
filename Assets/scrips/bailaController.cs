using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bailaController : MonoBehaviour
{
    public Animator animController;
    public AudioSource audioPersonaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //para recibir un toque en la pantalla aunque la instruccion sea para recibir un click
        if (Input.GetMouseButton(0))
        {
            animController.SetBool("baila", true);
        }
        if (animController.GetCurrentAnimatorClipInfo(0)[0].clip.name=="Rumba"||animController.GetCurrentAnimatorClipInfo(0)[0].clip.name == "ninja")
        {
            animController.SetBool("baila", false);
            if (!audioPersonaje.isPlaying)
            {
                audioPersonaje.Play();
            }
        }
        if (animController.GetCurrentAnimatorClipInfo(0)[0].clip.name == "Idle")
        {
            audioPersonaje.Pause();
        }

    }
}
