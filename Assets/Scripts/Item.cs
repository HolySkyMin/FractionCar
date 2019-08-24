using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Item : MonoBehaviour
{
    public ItemType Type; // None, Upgrade, Breaker, 

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switch (Type)
            {
                case ItemType.Upgrade:
                    IngameManager.Instance.Data.CurMoney += 5;
                    break;
                case ItemType.Runner:
                    IngameManager.Instance.HasRunner = true;
                    break;
                case ItemType.Breaker:
                    IngameManager.Instance.HasBreaker = true;
                    break;
            }
            IngameManager.Instance.Scroller.FieldObjects.Remove(gameObject);
            Destroy(gameObject);
        }
    }
}
