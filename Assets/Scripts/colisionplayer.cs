using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionplayer : MonoBehaviour
{
    [SerializeField] int contador = 0;
    private int final = 10;
    private int puntosRecolectable = 1;

    private void OnTriggerEnter(Collider otherCollider)
    {
        //Muerocuando coqué contra el objeto ETIQUETADO como "Obatcle"
        if (gameObject.CompareTag("Player") && otherCollider.gameObject.CompareTag("obstacle"))
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }
        //conjsigo puntos cuando choco contra el objeto ETIQUETADO como "recolctable", si llego a 10 gano
        if (gameObject.CompareTag("Player") && otherCollider.gameObject.CompareTag("recolectable"))
        {
            contador += puntosRecolectable;
            Destroy(otherCollider.gameObject);

            if(contador < final)
            {
                Debug.Log($"Tienes {contador} puntos.");
               
            } 
           if(contador == final)
                {
                    Debug.Log("¡ENHORABUENA!¡HAS GANADO!");
                    Time.timeScale = 0;
                }
        }
        //el projectil explita y mata al ostaculo
        if (gameObject.CompareTag("proyectil") && otherCollider.gameObject.CompareTag("obstacle"))
        {
            Destroy(gameObject);
            Destroy(otherCollider.gameObject);
        }


    }
}
