using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Collider2D))]
public class Character : MonoBehaviour
{
    
    public bool CurrentLine;
    public bool CurrentLine2;
    public DataController dataController;
    public FloorScroller Scroller;
    Vector3 vector;
    Vector3 vector2;

   
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
        vector.x = -30;
        vector2.x = 30;
        CurrentLine = true;
        // TODO: 오브젝트 움직이는 기능 : 양엎으로까지.
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {

            int ClickMove = IngameManager.Instance.Data.DeltaTravel;
            IngameManager.Instance.Data.CurTravel += ClickMove;       
            Scroller.MoveFloor();
            
        }
        if (vector.x == this.transform.position.x)
        {
            CurrentLine = false;
        }
        else
        {
            CurrentLine = true;
        }
        if (vector2.x == this.transform.position.x)
        {
            CurrentLine2 = false;
        }
        else
        {
            CurrentLine2 = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (CurrentLine == true)
            {
                this.transform.Translate(-30, 0, 0);
                
            }
           




        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (CurrentLine2 == true)
            {
                this.transform.Translate(30, 0, 0);
            }
            
        }

    }
}
