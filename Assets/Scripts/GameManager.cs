using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SelectFirstPlayer();
    }

    void SelectFirstPlayer() {
        int number = Random.Range(1,3);
        Debug.Log("Numero: "+number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
