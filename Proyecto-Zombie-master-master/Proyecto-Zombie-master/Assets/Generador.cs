using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    GameObject ZombieMesh;
    GameObject Gente;
    CosasZombie datoZombi;
    CosasCiudadanos datoCiudadanos;
   
    

    void Start()
    {



        int numPersonaje = Random.Range(9, 20);             // random para la creacion de los Npc
        for (int i = 0; i < numPersonaje; i++)
        {



            ZombieMesh = GameObject.CreatePrimitive(PrimitiveType.Cube);                        // creacion de un primityve como cubo y se allade el scritp como se cree el zombi
            ZombieMesh.AddComponent<ZombieOp>();
            datoZombi = ZombieMesh.GetComponent<ZombieOp>().datosZombi;
            switch (datoZombi.colorEs)                                                  // funcion para la creacion de color al zombi
            {
                case CosasZombie.ColorZombie.magenta:
                    ZombieMesh.GetComponent<Renderer>().material.color = Color.magenta;

                    break;
                case CosasZombie.ColorZombie.green:
                    ZombieMesh.GetComponent<Renderer>().material.color = Color.green;

                    break;
                case CosasZombie.ColorZombie.cyan:
                    ZombieMesh.GetComponent<Renderer>().material.color = Color.cyan;

                    break;
            }
            Vector3 pos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));         // random para la pocicion del zombi
            ZombieMesh.transform.position = pos;
            ZombieMesh.AddComponent<Rigidbody>();
            ZombieMesh.name = "Zombi";

            Gente = GameObject.CreatePrimitive(PrimitiveType.Cube);                 // creacion de un primitive para los aldeanos y allade el scrit de ciudadanos
            Gente.AddComponent<CiudadanoOp>();
            //datoCiudadanos = Gente.GetComponent<CiudadanoOp>().genteNombre
            Vector3 po = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));  //random de la pocicion del aldeano
            Gente.transform.position = po;
            Gente.AddComponent<Rigidbody>();
            Gente.name = "Gente";


        }
       

    }

    
    void Update()
    {
        
    }
}
