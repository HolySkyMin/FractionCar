using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScroller : MonoBehaviour
{
    public GameObject[] FloorObject;
    public float Distance;

    private Queue<GameObject> floorQueue;

    // Start is called before the first frame update
    void Start()
    {
        floorQueue = new Queue<GameObject>();
        for (int i = 0; i < FloorObject.Length; i++)
            floorQueue.Enqueue(FloorObject[i]);
    }

    public void MoveFloor()
    {
        foreach (var obj in floorQueue)
        {
            obj.transform.Translate(0, -2, 0);
        }

        if (floorQueue.Peek().transform.localPosition.y <= Distance * -1)
        {
            floorQueue.Peek().transform.localPosition = new Vector3(0, Distance, 0);
            floorQueue.Enqueue(floorQueue.Dequeue());
        }
    }
}
