using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour
{

    

    //Metodo para eliminar Objeto
    private void OnTriggerEnter2D(Collider2D other){

            if(other.name=="Naranja" || other.name=="Pera" ||
            other.name=="Banano" || other.name=="Insecto"){

            
            Debug.Log("Detectado");
            Destroy(other.gameObject);
            }
    }

    


}
