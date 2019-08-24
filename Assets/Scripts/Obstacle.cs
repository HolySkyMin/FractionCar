using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(IngameManager.Instance.HasBreaker)
            {
                IngameManager.Instance.breakerDuration = 3;
                IngameManager.Instance.HasBreaker = false;
            }
            else if(!IngameManager.Instance.HasRunner)
            {
                IngameManager.Instance.HasStun = true;
            }
            IngameManager.Instance.Scroller.FieldObjects.Remove(gameObject);
            Destroy(gameObject);
        }
    }
}
