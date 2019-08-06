using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollManager : MonoBehaviour
{
    public GameObject go;
    
    private bool activated;

    
    public void OneClick()
    {
        activated = !activated;
            if(activated)
            {
                go.SetActive(true);
            }
            else
            {
                go.SetActive(false);
            }
    }
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            activated = !activated;
            if(activated)
            {
                go.SetActive(true);
            }
            else
            {
                go.SetActive(false);
            }
        }
    }
    public void ExitClick()
    {
        activated = false;
        go.SetActive(false);
    }
}
