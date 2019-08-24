using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Collider2D))]
public class Character : MonoBehaviour
{
    public int CurrentLine;
    public FloorScroller Scroller;
    public List<GameObject> Humans;
    public GameObject Barrier, Booster;

    public void Initialize()
    {
        Humans = new List<GameObject>();
        for(int i = 0; i < IngameManager.Instance.Data.AbilityValue[0] + 1; i++)
        {
            var newHuman = Instantiate(Resources.Load<GameObject>("Prefabs/Human"));
            newHuman.transform.SetParent(transform);
            newHuman.SetActive(true);
            Humans.Add(newHuman);
        }
        ResetHumanPosition();
    }

    public void ResetHumanPosition()
    {
        float startPoint = -0.15f * (Humans.Count - 1);
        for(int i = 0; i < Humans.Count; i++)
            Humans[i].transform.localPosition = new Vector3(startPoint + 0.3f * i, -1, -0.1f);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.F))
        {
            if(!IngameManager.Instance.HasStun)
            {
                IngameManager.Instance.CurTravel += IngameManager.Instance.DeltaTravel * (IngameManager.Instance.HasRunner ? 2 : 1);
                Scroller.MoveFloor(IngameManager.Instance.HasRunner ? 2 : 1);
                IngameManager.Instance.Spawner.TravelDistance += IngameManager.Instance.DeltaTravel;

                foreach (var human in Humans)
                    human.GetComponent<SpriteRenderer>().flipX = !human.GetComponent<SpriteRenderer>().flipX;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(CurrentLine > 0 && !IngameManager.Instance.HasStun)
            {
                CurrentLine--;
                transform.DOLocalMoveX(IngameManager.Instance.LinePosition[CurrentLine].localPosition.x, 0.5f);
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && !IngameManager.Instance.HasStun)
        {
            if(CurrentLine < 2)
            {
                CurrentLine++;
                transform.DOLocalMoveX(IngameManager.Instance.LinePosition[CurrentLine].localPosition.x, 0.5f);
            }
        }

        if (IngameManager.Instance.HasRunner)
            Booster.SetActive(true);
        else
            Booster.SetActive(false);
        if (IngameManager.Instance.HasBreaker)
            Barrier.SetActive(true);
        else
            Barrier.SetActive(false);
    }
}
