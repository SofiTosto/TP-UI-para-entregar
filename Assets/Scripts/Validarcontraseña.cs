using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Validarcontraseña : MonoBehaviour
{

    string contracorrecta;
    string contrausuario;
    public Text ingresousuario;
    public Text textomensaje;
    public GameObject cartelito;
    // Start is called before the first frame update
    void Start()
    {
        contracorrecta = "12345";
        cartelito.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void validarcontraseña()
    {
        contrausuario = ingresousuario.text;
        if (contrausuario == contracorrecta)
        {
            cartelito.SetActive(true);
            textomensaje.text = "¡Bienvenido!";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelito.SetActive(true);
            textomensaje.text = "Su contraseña es incorrecta";
            Debug.Log("Su contraseña es incorrecta");
        }
    }
}
 