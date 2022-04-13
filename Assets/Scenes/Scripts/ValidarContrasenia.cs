using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour {
    string contraseniacorrecta;
    string contraseniausuario;
    public int tumamam;
    public Text ingresousuario;
    public Text textomsj;
    public GameObject cartel;
	// Use this for initialization
	void Start () {
        contraseniacorrecta = "12345";
        cartel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void validarcontrasenia()
    {
        contraseniausuario = ingresousuario.text;
        if (contraseniacorrecta == contraseniausuario)
        {
            cartel.SetActive(true);
            textomsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartel.SetActive(true);
            textomsj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
