using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public Transform SpawnParent;

    public float TravelDistance;

    private const float SPAWN_THRESHOLD = 10;

    // Update is called once per frame
    void Update()
    {
        if(TravelDistance >= SPAWN_THRESHOLD)
        {
            SpawnObject();
            TravelDistance -= SPAWN_THRESHOLD;
        }
    }

    public void SpawnObject()
    {
        int obstacleCount = 0;

        for(int i = 0; i < 3; i++)
        {
            int rnd = Random.Range(0, 100);
            if (rnd.IsBetween(0, 50)) // 아무것도 생성되지 않음
                continue;
            else if(rnd.IsBetween(50, 85)) // 아이템
            {
                GameObject newObj;
                if (rnd.IsBetween(50, 75))
                    newObj = Instantiate(Resources.Load<GameObject>($"Prefabs/UpgradeItem{IngameManager.Instance.CurStage}"));
                else if (rnd.IsBetween(75, 80))
                    newObj = Instantiate(Resources.Load<GameObject>($"Prefabs/BoostItem"));
                else
                    newObj = Instantiate(Resources.Load<GameObject>($"Prefabs/BreakerItem"));
                newObj.transform.SetParent(SpawnParent);
                newObj.transform.localPosition = IngameManager.Instance.LinePosition[i].localPosition;
                newObj.SetActive(true);
                IngameManager.Instance.Scroller.FieldObjects.Add(newObj);
            }
            else if(rnd.IsBetween(80, 100) && obstacleCount < 2) // 장애물
            {
                var newObj = Instantiate(Resources.Load<GameObject>($"Prefabs/Obstacle{IngameManager.Instance.CurStage}"));
                newObj.transform.SetParent(SpawnParent);
                newObj.transform.localPosition = IngameManager.Instance.LinePosition[i].localPosition;
                newObj.SetActive(true);
                IngameManager.Instance.Scroller.FieldObjects.Add(newObj);
                obstacleCount++;
            }
        }
    }
}
