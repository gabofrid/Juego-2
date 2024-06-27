using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PRODUCTSGENERATOR : MonoBehaviour
{
    public GameObject [] productosDerecha;
    public GameObject[] productosIzquierda;

    public Text txtPrecio1;
    public Text txtPrecio2;
    public Text txtPlata;
    public Text txtPerdiste;
    public Text txtGanaste;
    public Text txtPlayAgain;


    int DineroDisponible;
    int precio1;
    int precio2;

    int Index1;
    int Index2;

    List<int> ProductosConPrecios = new List<int>();
      void Start()
    {
        DineroDisponible = Random.Range(100, 1000);
        txtPlata.text = "$" + DineroDisponible.ToString();
        PreciosAleatorios();
        txtPerdiste.text = "";
        txtGanaste.text = "";
        txtPlayAgain.text = "Reiniciar el desafío";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PreciosAleatorios()
    {
        DeactivateAll();
        ActiveProducto();
        int index1 = Random.Range(0, productosDerecha.Length);     // metodo para agarrar dos objetos randoms entre los productos
        int index2 = Random.Range(0, productosIzquierda.Length -1);
        Index1 = index1;
        Index2 = index2;
        if (index2 == index1)   // para ver que no agarre el mismo objeto
        {
            index2++;
        }
        precio1 = Random.Range(100, 500);
        precio2 = Random.Range(100, 500);

        txtPrecio1.text = "$" + (precio1).ToString ();
        txtPrecio2.text = "$" + (precio2).ToString();

        ProductosConPrecios.Add (precio1);
        ProductosConPrecios.Add(precio2);


    }
    public void btnPlayAgain1()
    {
        // si tocan el boton reiniciar
        DineroDisponible = Random.Range(100, 1000);
        txtPlata.text = DineroDisponible.ToString();
        ProductosConPrecios.Clear();
        PreciosAleatorios();
        txtGanaste.text = "";
        txtPerdiste.text = "";
        txtPlayAgain.text = "Reiniciar el desafío";


    }

    public void btnAlcanzaJusto1()
    {

        if (DineroDisponible == precio1 + precio2)
        {
            Debug.Log("Ganaste");
            txtPerdiste.text = "";
            txtGanaste.text = "¡GANASTE!";
            txtPlayAgain.text = "Reiniciar el desafío";

            // abrir panel por si quiere seguir jugando o no, con el respectivo mensaje
        }
        else
        {
            Debug.Log("Perdiste");
            txtPerdiste.text = "PERDISTE:(";
            txtGanaste.text = "";
            txtPlayAgain.text = "Volver a intentarlo";
            // abrir panel por si quiere seguir jugando o no, con el respectivo mensaje
        }
    }

    public void btnAlcanza1()
    {
        if (DineroDisponible > precio1 + precio2)
        {
            Debug.Log("Ganaste");
            txtPerdiste.text = "";
            txtGanaste.text = "¡GANASTE!";
            txtPlayAgain.text = "Reiniciar el desafío";
            // abrir panel por si quiere seguir jugando o no, con el respectivo mensaje
        }
        else
        {
            Debug.Log("Perdiste");
            txtPerdiste.text = "PERDISTE:(";
            txtGanaste.text = "";
            txtPlayAgain.text = "Volver a intentarlo";
            // abrir panel por si quiere seguir jugando o no, con el respectivo mensaje
        }
    }
    public void btnNoAlcanza1()
    {
        if (DineroDisponible < precio1 + precio2)
        {
            Debug.Log("Ganaste");
            txtPerdiste.text = "";
            txtGanaste.text = "¡GANASTE!";
            txtPlayAgain.text = "Reiniciar el desafío";
            // abrir panel por si quiere seguir jugando o no, con el respectivo mensaje
        }
        else
        {
            Debug.Log("Perdiste");
            txtPerdiste.text = "PERDISTE:(";
            txtGanaste.text = "";
            txtPlayAgain.text = "Volver a intentarlo";
            // abrir panel por si quiere seguir jugando o no, con el respectivo mensaje
        }
    }

    private void DeactivateAll()
    {
        for (int i = 0; i < productosIzquierda.Length; i++)
        {
            productosIzquierda[i].SetActive(false);
            productosIzquierda[i].SetActive(false);
        }

        for (int i = 0; i < productosDerecha.Length; i++)
        {
            productosDerecha[i].SetActive(false);
            productosDerecha[i].SetActive(false);
        }
    }

    private void ActiveProducto()
    {
        productosDerecha[Index1].SetActive(true);
        productosIzquierda[Index2].SetActive(true);
    }
}
