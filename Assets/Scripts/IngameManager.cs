using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameManager : MonoBehaviour
{
    public static IngameManager Instance { get; private set; }

    public FloorScroller Scroller;
    public DataController dataController;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            int ClickMove = dataController.GetClickMove();

            dataController.AddMove(ClickMove);
            //Move += ClickMove;
            Scroller.MoveFloor();
        }
    }

    private void LateUpdate()
    {
        
    }
}
