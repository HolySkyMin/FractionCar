using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // c
        int num = Random.Range(0, 3);
        gameObject.transform.position = new Vector3(num, 0, 0);
    }
}
