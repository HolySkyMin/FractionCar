using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Character : MonoBehaviour
{
    public int CurrentLine;

    // Start is called before the first frame update
    void Start()
    {
        CurrentLine = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        // TODO: 오브젝트 움직이는 기능 : 양엎으로까지.
    }
}
