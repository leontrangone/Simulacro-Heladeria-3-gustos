using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SimlacroHeladeria : MonoBehaviour
{

    public string gusto;
    public float cantidad;

    int cantMaxima = 3000;
    int cantMinima = 250;

    float precioGramo = 1.25f;
    float descuento = 0.10f;

    float precioFinal;
    
    // Start is called before the first frame update
    void Start()
    {

       if (cantidad < cantMinima || cantidad > cantMaxima)
        {
            Debug.Log("Cantidad de helado no válida");
            return;
        }

        if (gusto != "CHO" && gusto != "DDL" && gusto != "FRU")
        {
            Debug.Log("Ingrese un código válido");
            return;
        }

        if (gusto == "CHO" || gusto == "cho")
        {
            precioFinal = cantidad * precioGramo;
            Debug.Log("El precio por la cantidad que pidio es de " + precioFinal);

        }
        else if (gusto == "FRU" || gusto == "fru")
        {
            precioFinal = (cantidad * precioGramo) - (cantidad * precioGramo) * descuento;
            Debug.Log("El precio por la cantidad que pidio es de " + precioFinal);

        }
        else if (gusto == "DDL" || gusto == "ddl")
        {
            precioFinal = cantidad * precioGramo;
            Debug.Log("El precio por la cantidad que pidio es de " + precioFinal);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
