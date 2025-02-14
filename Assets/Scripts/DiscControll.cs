using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscControll : MonoBehaviour
{
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D (Collision2D coll) {
        if(coll.collider.CompareTag("Player")){
            Rigidbody2D rb = coll.collider.GetComponent<Rigidbody2D>();
            // Verificando se o Rigidbody2D foi encontrado
            if (rb != null) {
                // Pegando a velocidade do objeto
                Vector2 velocidade = rb.velocity;
                rb2d.AddForce(new Vector2(30*velocidade.x, 30*velocidade.y));
                
                // Exibindo a velocidade no console
                Debug.Log("Velocidade do Player: " + velocidade);
            } else {
                Debug.LogWarning("Rigidbody2D não encontrado no objeto colidido.");
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
