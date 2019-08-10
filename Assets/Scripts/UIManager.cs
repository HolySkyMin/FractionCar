using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text Move_Text;
    public DataController dataController;

    void Update()
    {
        Move_Text.text = "레벨:" + dataController.GetLevel()+"  " + "총거리: " + dataController.GetMove()+"m";
        
    }
}
