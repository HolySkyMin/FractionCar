using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider2D))]
public class Character : MonoBehaviour
{
    
    public bool CurrentLine;
    public DataController dataController;
    public FloorScroller Scroller;
   
    // Start is called before the first frame update
    void Start()
    {

        //CurrentLine = 0;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
                
    }
    // Update is called once per frame
    private void Update()
    {
        CurrentLine = true;
        // TODO: 오브젝트 움직이는 기능 : 양엎으로까지.
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            int ClickMove = dataController.GetClickMove();

            dataController.AddMove(ClickMove);
            //Move += ClickMove;
            Scroller.MoveFloor();
            
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (CurrentLine == true)
            {
                this.transform.Translate(-22, 0, 0);
            }
            
            
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (CurrentLine == true)
            {
                this.transform.Translate(22, 0, 0);
            }
            
        }

    }
}
