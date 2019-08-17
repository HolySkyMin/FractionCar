using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneManage : MonoBehaviour
{
    public int NeedLevel;
    public string goScene;
    public GameObject gameObject;
    public Camera camera;
    public Canvas canvas;
    public GameObject data;
    public bool isMoving;

    public int i;
    public string[] MapName;
    private Queue<string> MapQue;
    // Start is called before the first frame update
    private void Awake()
    {
        MapQue = new Queue<string>();
        for (int i = 0; i < MapName.Length; i++)
            MapQue.Enqueue(MapName[i]);
    }
    void Start()
    {
        i = 0;
        NeedLevel = 2;
        DontDestroyOnLoad(this);
        DontDestroyOnLoad(camera);
        DontDestroyOnLoad(canvas);
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(data);
    }

    // Update is called once per frame
    void Update()
    {
        MoveScene();     
        
    }
    void MoveScene()
    {
        if (IngameManager.Instance.Data.StageLevel == NeedLevel)
        {
            NeedLevel += 1;
            SceneManager.LoadScene(MapName[i]);
            i++;                 
            }
    }
}
