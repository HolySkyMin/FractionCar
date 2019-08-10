using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManage : MonoBehaviour
{
    public  int NeedLevel;
    public char goScene;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        if(IngameManager.Instance.Data.StageLevel == NeedLevel)
        {
            SceneManager.LoadScene(goScene);
        }
    }
}
