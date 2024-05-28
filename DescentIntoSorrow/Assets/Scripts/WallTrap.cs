using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTrap : MonoBehaviour
{
    public GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        
    }
    private void Update()
    {
        if (CompareTag("FakeDoor"))
        {
            Instantiate(objectToSpawn);
        }

    }

}
