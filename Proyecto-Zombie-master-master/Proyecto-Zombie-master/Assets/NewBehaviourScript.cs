using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public int limitecreacion = 10;
    int Ezombi, Ngente, Nedad;
    int colorzombie;
    string NNombre;
    int intNombre;



    class zombie
    {
       // public string name;
        //public int brainsEaten;
        //public int hitPoints;
        public string zombicolor;
        
        GameObject zombieMesh;



        public zombie( int colorzombie)
        {
            //name = n;
          // brainsEaten = 0;
            //hitPoints = hp;
            zombieMesh = GameObject.CreatePrimitive
            (PrimitiveType.Capsule);
            Vector3 pos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            zombieMesh.transform.position = pos;
            zombieMesh.AddComponent<Rigidbody>();
            //pos.x = Random.Range(-10,10);
            //pos.y = 0f;
            //pos.z = Random.Range(-10,10);
            //zombieMesh.transform.position = pos;

            int colores = Random.Range(0, 3);
           

            colores = colorzombie;

            
            switch (colores)
            {
                case 0:
                    zombieMesh.GetComponent<Renderer>().material.color = Color.magenta;
                    zombicolor = "magenta";
                    break;
                case 1:
                    zombieMesh.GetComponent<Renderer>().material.color = Color.green;
                    zombicolor = "green";
                    break;
                case 2:
                    zombieMesh.GetComponent<Renderer>().material.color = Color.cyan;
                    zombicolor = "cyan";
                    break;
            }
            Debug.Log(Mensajezombi(zombicolor));
        }
        string Mensajezombi (string zombicolor)
        {
            string mensaje;

            mensaje = "soy un zombi de color " + zombicolor;
            return mensaje;
        }

        

    }


    void Start()
    {

        Ezombi = Random.Range(5, limitecreacion + 1);
        Ngente = limitecreacion - Ezombi;
        Ngente = Random.Range(0, Ngente + 1);

        for (int i = 0; i < Ezombi; i++)
        {
            colorzombie = Random.Range(0, 3);
            zombie z = new zombie(colorzombie);
        }





        //string[] names = new string[]
        //     {
        //          "stubbs",
        //          "rob",
        //          "white"
        //     };
        //for (int i = 0; i < names.Length; i++)
        //{
        //    zombie z = new zombie(names[i], Random.Range(10, 15));
        //    Debug.Log(z.name);
        //}



        string[] Nombre = new string[]
        {
                  "stubbs",
                  "rob",
                  "toreto",
                  "pequeño tim",
                  "don carlos",
                  "carlos 1",
                  "carlos 2",
                  "sergio",
                  "stevan",
                  "tu tia en tanga",
                  "panzerotte del sena ",
                  "cj",
                  "hay te voy sam pedro",
                  "san peludo",
                  "alexianismo :v",
                  "puto alexis",
                  "jason",
                  "andrey",
                  "atreus",
                  "artion",
                  "kratos",
                  "zeus",
                  "loki",
                  "puto el que lo lea",
                  "wilson",
                  "el brayan",
                  "venites ",
                  "sam pedro",



        };
        for (int i = 0; i < Ngente; i++)
        {
            //Gente z = new Gente(Nombre[i], Random.Range(0,9));
            //Debug.Log(z.Nombres);

            intNombre = Random.Range(0, 20);
            NNombre = Nombre[intNombre];
            Nedad = Random.Range(15, 100);

            Gente gentevivita = new Gente(NNombre,Nedad);

           
            Debug.Log( " hola mi nombre es " + NNombre + " y tengo "+ Nedad);

        }

         
    }





    class Gente
    {

        public string Nombres;
        public int Edad;
        GameObject Gentusa;
        string mensajegente;

        public Gente(string NNombre, int Nedad)
        {
            Nombres = NNombre;
            Edad = Nedad;
            Gentusa = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 Gentusapo = new Vector3();
            Gentusapo.x = Random.Range(-10, 10);
            Gentusapo.y = 0f;
            Gentusapo.z = Random.Range(-10, 10);
            Gentusa.transform.position = Gentusapo;
            Gentusa.AddComponent<Rigidbody>();

            int colorr = Random.Range(0, 2);
            switch (colorr)
            {
                case 0:
                    Gentusa.GetComponent<Renderer>().material.color = Color.blue;
                    break;
                case 1:
                    Gentusa.GetComponent<Renderer>().material.color = Color.red;
                    break;
                    
            }


            


        }
       
        


            
           





    }
        
        







}