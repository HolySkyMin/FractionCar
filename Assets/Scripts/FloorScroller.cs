using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FloorScroller : MonoBehaviour
{
    public GameObject[] FloorObject;
    public List<GameObject> FieldObjects;
    public float Distance;

    private Queue<GameObject> floorQueue;

    // Start is called before the first frame update
    void Start()
    {
        floorQueue = new Queue<GameObject>();
        for (int i = 0; i < FloorObject.Length; i++)
            floorQueue.Enqueue(FloorObject[i]);
    }

    public void MoveFloor(int multiply)
    {
        foreach (var obj in floorQueue)
            obj.transform.Translate(0, -IngameManager.Instance.DeltaTravel * multiply, 0);
        foreach(var obj in FieldObjects)
            obj.transform.Translate(0, -IngameManager.Instance.DeltaTravel * multiply, 0);

        if (floorQueue.Peek().transform.localPosition.y <= Distance * -1)
        {
            floorQueue.Peek().transform.localPosition += new Vector3(0, 2 * Distance, 0);
            floorQueue.Enqueue(floorQueue.Dequeue());
        }
        for(int i = 0; i < FieldObjects.Count; i++)
        {
            if(FieldObjects[i].transform.localPosition.y <= Distance * -1.3f)
            {
                Destroy(FieldObjects[i]);
                FieldObjects.RemoveAt(i--);
            }
        }
    }
}
