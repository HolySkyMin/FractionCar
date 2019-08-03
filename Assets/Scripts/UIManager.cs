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
        Move_Text.text = "이동한 거리" + dataController.GetMove();    
    }
}
