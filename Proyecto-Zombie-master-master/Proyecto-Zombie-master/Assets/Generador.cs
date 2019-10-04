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



        int numPersonaje = Random.Range(9, 20);
        for (int i = 0; i < numPersonaje; i++)
        {



            ZombieMesh = GameObject.CreatePrimitive(PrimitiveType.Cube);
            ZombieMesh.AddComponent<ZombieOp>();
            datoZombi = ZombieMesh.GetComponent<ZombieOp>().datosZombi;
            switch (datoZombi.colorEs)
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
            Vector3 pos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            ZombieMesh.transform.position = pos;
            ZombieMesh.AddComponent<Rigidbody>();
            ZombieMesh.name = "Zombi";

            Gente = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Gente.AddComponent<CiudadanoOp>();
            //datoCiudadanos = Gente.GetComponent<CiudadanoOp>().genteNombre
            Vector3 po = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            Gente.transform.position = po;
            Gente.AddComponent<Rigidbody>();
            Gente.name = "Gente";


        }
       

    }

    
    void Update()
    {
        
    }
}
