using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    public GameObject item;
    // Start is called before the first frame update
    void Start()
    {

        
        
            Instantiate(item);

        
    }
        // Update is called once per frame
        void Update()
        {
        
        }
}
