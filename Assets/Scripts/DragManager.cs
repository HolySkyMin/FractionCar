﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragManager : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("Begin Drag");
    }
    public void OnDrag(PointerEventData eventData)
    {
       transform.position = eventData.position;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
      // Debug.Log("End Drag");
    }
    public void OnDrop(PointerEventData eventData)
    {
     //  Debug.Log("Drop");
    }
}
