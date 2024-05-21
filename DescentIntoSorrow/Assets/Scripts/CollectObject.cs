using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Awake()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerMovement.hasKey = true;
            Destroy(gameObject);
        }

    }
}
