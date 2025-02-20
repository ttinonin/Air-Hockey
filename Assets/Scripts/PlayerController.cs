using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;  
    private float velocidade = 10f;
    private Vector2 lastPosition;
    public Vector2 minLimite, maxLimite;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lastPosition = transform.position;
    }

    void GetMousePos() {
        // Converte a posição do mouse para a posição do mundo do jogo
        Vector2 posMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Calcula a direção para onde a raquete deve ir
        Vector2 direcao = (posMouse - rb.position).normalized;
        

        // Define a velocidade baseada na direção e força da velocidade
        //rb.linearVelocity = direcao * velocidade;
        if (direcao.magnitude > 0.1f) { 
            rb.linearVelocity = direcao.normalized * velocidade;
        } else { 
            rb.linearVelocity = Vector2.zero; // Para quando chega perto
        }
        
        rb.position = new Vector2(
            Mathf.Clamp(rb.position.x, minLimite.x, maxLimite.x),
            Mathf.Clamp(rb.position.y, minLimite.y, maxLimite.y)
        );
        
    }

    // Update is called once per frame
    void Update()
    {
        GetMousePos();
    }
}
