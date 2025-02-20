using UnityEngine;

public class Oponent : MonoBehaviour
{
    public float dist_inicio_raquete=0.5f;
    public Transform bola;
    public Vector2 coordenadas_iniciais;
    private Rigidbody2D rb;  
    private float velocidade = 5f;
    private Vector2 lastPosition;
    public float minLimite, limiteX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (bola.position.y > minLimite) { 
            MoverParaBola();
        } else {
            MoverParaInicio(); 
        }
    }

    void MoverParaBola(){
        Vector2 destino = new Vector2(bola.position.x, bola.position.y);

        // Move suavemente a raquete em direção ao destino
        rb.linearVelocity = (destino - rb.position).normalized * velocidade;
    }
    void MoverParaInicio(){
        Vector2 destino = new Vector2(coordenadas_iniciais.x, coordenadas_iniciais.y);
        //rb.linearVelocity = (destino - rb.position).normalized * velocidade;
        // Move suavemente a raquete em direção ao destino
        if((destino - rb.position).x > dist_inicio_raquete || (destino - rb.position).y > dist_inicio_raquete){
            rb.linearVelocity = (destino - rb.position).normalized * velocidade;
        }
        else{
            rb.linearVelocity = Vector2.zero;
        }
        
    }
}
