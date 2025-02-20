using UnityEngine;

public class Gols : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D (Collider2D hitInfo) {
        if (hitInfo.tag == "Ball")
        {
            string golName = transform.name;
            GameManager.Score(golName);
            hitInfo.gameObject.SendMessage("RestartGame", null, SendMessageOptions.RequireReceiver);
        }
    }

}
