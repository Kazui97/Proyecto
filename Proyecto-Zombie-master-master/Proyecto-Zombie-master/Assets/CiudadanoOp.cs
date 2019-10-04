using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CiudadanoOp : MonoBehaviour
{
    public CosasCiudadanos datoCiudadanos;      //variable de la estructura del ciudadano

    void Awake()
    {


        int darnombre = Random.Range(0, 20);            //rando de los nombre del ciudadano
        datoCiudadanos.genteNombres = (CosasCiudadanos.Nombres)darnombre;
        int daredad = Random.Range(15, 100);                //random de la edad
        datoCiudadanos.edadgente = (CosasCiudadanos.Edad)daredad;

    }

    
    void Update()
    {
        
    }
}

public struct CosasCiudadanos       // estructuras y enum de los ciudadanos 
{
   public enum Nombres
    {
        stubbs,
        rob,
        toreto,
        pequeñotim,
        doncarlos,
        carlosII,
        carlosI,
        sergio,
        stevan,
        tutiaentanga,
        panzerottedelsena,
        cj,
        haytevoysampedro,
        sanpeludo,
        alexisdelpeludoII,
        putoalexis,
        jason,
        andrey,
        atreus,
        artion,
        kratos,
        zeus,
        loki,
        sam,
        wilson,
        elbrayan,
        venites,
        sampedro,
    }
    public Nombres genteNombres;

    public enum Edad
    {
        edad
    }
    public Edad edadgente;
}
