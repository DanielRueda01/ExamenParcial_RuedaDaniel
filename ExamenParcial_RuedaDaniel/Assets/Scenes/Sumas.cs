using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Sumas : MonoBehaviour
{
    private int inicio;
    private int pregunta;
    private int numero;
    public TMP_InputField input;
    public TMP_Text text;



    void Start()
    {
        NumeroAzar1();
        Inicio();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void NumeroAzar1()
    {
        numero = Random.Range(0, 10);
    }

    public void Operacion() 
    {
        int.TryParse(input.text, out numero);
        
        if (numero == pregunta)
        {
            text.text = "¿Cuál es el Resultado?" + pregunta.ToString();
        }
        else if (numero < pregunta)
        {
            text.text = "Correcto :)";
        }
        else
        {
            text.text = "Incorrecto :(";
        }
    }


    void Inicio()
    {
        text.text = "¡Juego de Sumas!";
    }

    public void BotonReinicio()
    {
        SceneManager.LoadScene(0);
    }
}


