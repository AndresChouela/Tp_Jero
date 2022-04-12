using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour {
    string contraseniacorrecta;
    string contraseniausuario;
    public Text ingresousuario;
	// Use this for initialization
	void Start () {
        contraseniacorrecta = "12345";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void validarcontrasenia()
    {
        contraseniausuario = ingresousuario.text;
        if (contraseniacorrecta == contraseniausuario)
        {
            Debug.Log("Bienvenido");
        }
        else
        {
            Debug.Log("Contraseña incorrecta");
        }
    }
}
