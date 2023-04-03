using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Ejercicios_1
{
    public class Ejercicio10 : MonoBehaviour
    {
        void Start()
        {
            GameObject[] names = FindObjectsOfType<GameObject>();

            for (int i = 0; names.Length >= i; i++)
            {
                names[i].transform.name = "Objeto";



            }

        }


    }
}