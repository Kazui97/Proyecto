using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CiudadanoOp : MonoBehaviour
{
    public CosasCiudadanos datoCiudadanos;

    void Awake()
    {


        int darnombre = Random.Range(0, 20);
        datoCiudadanos.genteNombres = (CosasCiudadanos.Nombres)darnombre;
        int daredad = Random.Range(15, 100);
        datoCiudadanos.edadgente = (CosasCiudadanos.Edad)daredad;

    }

    
    void Update()
    {
        
    }
}

public struct CosasCiudadanos
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
