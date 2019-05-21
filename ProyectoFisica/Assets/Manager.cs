using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject gas;
    public GameObject piston;
    public GameObject mercurio;
    private Vector3 escala;
    private Vector3 posicion;
    private Vector3 pos;

    private Vector3 escalaMercurio;
    private Vector3 posicionMercurio;


    public Slider temperatura;
    public Slider presion;
    public Slider moles;

    // Start is called before the first frame update
    void Start()
    {
        escala = gas.transform.localScale;
        posicion = gas.transform.position;
        pos = piston.transform.position;

        escalaMercurio = mercurio.transform.localScale;
        posicionMercurio = mercurio.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        float valor = (temperatura.value*moles.value*8.314f)/(presion.value*5);
        Vector3 nombre = escala;
        Vector3 nombre2 = posicion;
        Vector3 nombre4 = escalaMercurio;
        nombre.z += (valor / 10) - 1;
        nombre2.z += ((valor / 10) - 1) / 2;
        gas.transform.localScale = nombre;//(gas.GetComponent<Transform>().localScale.x, gas.GetComponent<Transform>().localScale.y, gas.GetComponent<Transform>().localScale.z + valor );
        gas.transform.position = nombre2;//new Vector3(gas.GetComponent<Transform>().position.x, gas.GetComponent<Transform>().position.y,gas.GetComponent<Transform>().position.z + valor /2);

        Vector3 nombre3 = pos;
        nombre3.z += (valor / 10) - 1;
        piston.transform.position = nombre3;

        //nombre4.z += ((temperatura.value/20)-1)+0.41f;
        //mercurio.transform.localScale = nombre4;
        //Vector3 nombre3Mercurio = posicionMercurio;
        //nombre3Mercurio.z += ((temperatura.value / 20))/2;
        //mercurio.transform.position = nombre3Mercurio;

        nombre4.z += ((temperatura.value / 10) - 1);
        mercurio.transform.localScale = nombre4;
        Vector3 nombre3Mercurio = posicionMercurio;
        nombre3Mercurio.z += ((temperatura.value / 10) - 1) / 2;
        mercurio.transform.position = nombre3Mercurio;

        //if (temperatura.value <= 50)
        //{
        //    //nombre4.z += ((temperatura.value / 20) - 1) + 0.551f;
        //    nombre4.z += ((temperatura.value / 10) - 1);
        //    mercurio.transform.localScale = nombre4;
        //    Vector3 nombre3Mercurio = posicionMercurio;
        //    nombre3Mercurio.z += ((temperatura.value / 10)-1) / 2;
        //    mercurio.transform.position = nombre3Mercurio;
        //    //if(temperatura.value <= 30)
        //    //{
        //    //    nombre4.z += 0.04f;
        //    //    mercurio.transform.localScale = nombre4;
        //    //    //Vector3 nombre3Mercurio = posicionMercurio;
        //    //    //nombre3Mercurio.z += ((temperatura.value / 20)) / 2;
        //    //   // mercurio.transform.position = nombre3Mercurio;
        //    //}
        //}
        //else
        //{
        //    nombre4.z += ((temperatura.value / 20) - 1) + 0.41f;
        //    mercurio.transform.localScale = nombre4;
        //    Vector3 nombre3Mercurio = posicionMercurio;
        //    nombre3Mercurio.z += ((temperatura.value / 20)) / 2;
        //    mercurio.transform.position = nombre3Mercurio;
        //}
    }

}
