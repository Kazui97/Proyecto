using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
     CosasZombie datosZombi; //variables de las estructra de los zombies
    CosasCiudadanos datoCiudadanos;//variables de las estructra de los aldeanos 
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)      //la funcion colicion 
    {
        if (collision.transform.name == "Zombi") // si coliciona con un zombi este le crea un mensaje que aparece en consola y tiene los gusto del zombi
        {
            datosZombi = collision.gameObject.GetComponent<ZombieOp>().datosZombi;
            Debug.Log("  waaarrr " + " quiero comer " +  datosZombi.sabroso);
        }


        if (collision.transform.name == "Gente") //si coliciona con un aldeano este le crea un mensaje que aparece en consola que tiene los nombre y edades de los aldeanos
        {
            datoCiudadanos = collision.gameObject.GetComponent<CiudadanoOp>().datoCiudadanos;
            Debug.Log("Hola soy " + datoCiudadanos.genteNombres + " y tengo " + datoCiudadanos.edadgente );
        }
    }



}



