using UnityEngine;
using System.Collections;
using System;

public class Points : MonoBehaviour {

	public TextMesh puntosText;
    private float puntos = 0;


    public void Start()
    {
        puntos = 0;
        puntosText.text = Convert.ToString(puntos);
    }

    /*public void Update()
    {
        puntos = puntos + 1;
        puntosText.text = "" + puntos;
    }*/

    public void AumentarContador()
    {
        puntos++;
        puntosText.text = Convert.ToString(puntos);
    }
	
	
}
