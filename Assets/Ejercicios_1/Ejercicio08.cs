using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere tres cubos cada uno el doble de grande que el anterior
    /// </summary>
    public class Ejercicios08 : MonoBehaviour
    {
        private void Start()
        {
            GameObject cub01 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject cub02 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject cub03 = GameObject.CreatePrimitive(PrimitiveType.Cube);

            cub01.transform.localScale = new Vector3();
            cub02.transform.localScale = Vector3.one * 2f;
            cub03.transform.localScale = Vector3.one * 4f;

            //❕ CrearFiguras(PrimitiveType.Cube, 3);
        }

        //❕
        public static void CrearFiguras(PrimitiveType figura, int cantidad, float separacion = 0f)
        {
            float x = -0.5f; //Para que el primero se dibuje en (0, 0, 0)
            for (int i = 0; i < cantidad; i++)
            {
                GameObject go = GameObject.CreatePrimitive(figura);
                float size = Mathf.Pow(2f, i); //1, 2, 4, 8, 16
                go.transform.localScale = Vector3.one * size;
                x += size/2f; //Empujamos el punto de creación la mitad del tamaño que tiene
                go.transform.position = new Vector3(x, 0f, 0f);
                x += size/2f; //Empujamos la otra mitad para retomar desde ahí en el próximo
                x += separacion; //Añadimos la separación que queremos entre cubos
            }
        }          
    }
}