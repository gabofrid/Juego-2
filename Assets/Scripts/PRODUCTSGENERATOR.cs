using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PRODUCTSGENERATOR : MonoBehaviour
{
    public GameObject [] productos;
    int DineroDisponible;
    int precio1;
    int precio2;

    List<int> ProductosConPrecios = new List<int>();
      void Start()
    {
        DineroDisponible = Random.Range(100, 1000);
        PreciosAleatorios();
     }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PreciosAleatorios()
    {
        int index1 = Random.Range(0, productos.Length);     // metodo para agarrar dos objetos randoms entre los productos
        int index2 = Random.Range(0, productos.Length -1);
        if (index2 == index1)   // para ver que no agarre el mismo objeto
        {
            index2++;
        }
        precio1 = Random.Range(100, 1000);
        precio2 = Random.Range(100, 1000);


        ProductosConPrecios.Add (precio1);
        ProductosConPrecios.Add(precio2);


    }
    public void JugardeNuevo()
    {
        // si tocan el boton reiniciar
        DineroDisponible = Random.Range(100, 1000);
        ProductosConPrecios.Clear();
        PreciosAleatorios();
    }

    public void btnAlcanzaJusto()
    {
        if (DineroDisponible == precio1 + precio2)
        {
            Debug.Log("Ganaste");
            // abrir panel por si quiere seguir jugando o no, con el respectivo mensaje
        }
        else
        {
            Debug.Log("Perdiste");
            // abrir panel por si quiere seguir jugando o no, con el respectivo mensaje
        }
    }

    public void btnAlcanza()
    {
        if (DineroDisponible > precio1 + precio2)
        {
            Debug.Log("Ganaste");
            // abrir panel por si quiere seguir jugando o no, con el respectivo mensaje
        }
        else
        {
            Debug.Log("Perdiste");
            // abrir panel por si quiere seguir jugando o no, con el respectivo mensaje
        }
    }
    public void btnNoAlcanza()
    {
        if (DineroDisponible < precio1 + precio2)
        {
            Debug.Log("Ganaste");
            // abrir panel por si quiere seguir jugando o no, con el respectivo mensaje
        }
        else
        {
            Debug.Log("Perdiste");
             // abrir panel por si quiere seguir jugando o no, con el respectivo mensaje
        }
    }

}
