using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieOp : MonoBehaviour
{
    

    // public string [] Gustos;
    public CosasZombie datosZombi;
    int cambimov;
   

     

    void Awake()
    {
        

        datosZombi.colorEs = (CosasZombie.ColorZombie)Random.Range(0, 3);

        int dargusto = Random.Range(0, 5);
        datosZombi.sabroso = (CosasZombie.Gustos)dargusto;

    }
    void Start()
    {
        datosZombi.condicion = (CosasZombie.Estados)0;
        StartCoroutine ("Cambioestado");
    }


    void Update()
    {
        

        switch(datosZombi.condicion)
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
    
   
    IEnumerator Cambioestado()
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



public struct CosasZombie
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