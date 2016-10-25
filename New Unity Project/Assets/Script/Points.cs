using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour {

	
	public TextMesh puntosText;
    public float puntos = 0;

    public void Update()
    {
        puntos = puntos + 1;
        puntosText.text = "" + puntos;
    }
	
	
}
