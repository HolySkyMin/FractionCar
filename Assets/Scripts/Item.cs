using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Item : MonoBehaviour
{
    public Character chara;
    public SpriteRenderer Renderer;
    public ItemType Type; // None, Upgrade, Breaker, 
    public int upgrade;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            
            
        }
        
        // TODO: 여기서 아이템 먹는 효과를 구현
        // 게임 데이터 접근은 GameManager.Instance.Data로
        // 인게임 접근은 IngameManager.Instance로
    }
    void Awake()
    {
        
    }
    
}
