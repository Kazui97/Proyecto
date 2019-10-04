using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieOp : MonoBehaviour
{
    

    // public string [] Gustos;
    public CosasZombie datosZombi;      // variable de la estructura de los zombies
    int cambimov;
   

     

    void Awake()
    {
        

        datosZombi.colorEs = (CosasZombie.ColorZombie)Random.Range(0, 3);       // genera un random de los colores para los zombis

        int dargusto = Random.Range(0, 5);                          // rango de los gustos del zombi
        datosZombi.sabroso = (CosasZombie.Gustos)dargusto;

    }
    void Start()
    {
        datosZombi.condicion = (CosasZombie.Estados)0;      // la implementacion de la corutinas del zombi o cambios de estado 
        StartCoroutine ("Cambioestado");
    }


    void Update()
    {
        

        switch(datosZombi.condicion)            // cambio de estados devido ala corutina 
        {
            case CosasZombie.Estados.Idle:
                transform.eulerAngles += new Vector3(0, 0.5f, 0);
                break;
            case CosasZombie.Estados.Moving:
                if (cambimov == 0)
                {
                    transform.position += new Vector3(0, 0, 0.03f);
                }
                else if (cambimov == 1)
                {
                    transform.position -= new Vector3(0, 0, 0.03f);
                }
                else if(cambimov == 2)
                {
                    transform.position -= new Vector3(0.03f, 0, 0.03f);
                }
                else if (cambimov == 3)
                {
                    transform.position += new Vector3(0.03f, 0, 0);
                }
                break;
            default:
                break;
        }
       








    }
    
   
    IEnumerator Cambioestado()          // la corutina se encar de cambiar los estado cada 5 segundo 
    {
        while (true)
        {
            if (datosZombi.condicion == (CosasZombie.Estados)0)
            {
                datosZombi.condicion = (CosasZombie.Estados)1;
                cambimov = Random.Range(0, 4);

            }
            else
            {
                datosZombi.condicion = (CosasZombie.Estados)0;
            }
            yield return new WaitForSeconds(5);
        }
    }

    
    

}



public struct CosasZombie       // la estructra que guarda los gustos , estados y colores deloszombies
{
    public enum Gustos 
    {
        Brazos,
        Piernas,
        Huesitos,
        Ojito,
        corazoncito
    };
    public Gustos sabroso;

    public enum Estados
    {
        Idle,
        Moving
    };
    public Estados condicion;

    public enum ColorZombie
    {
        magenta,
        green, 
        cyan
    };
    public ColorZombie colorEs;
}