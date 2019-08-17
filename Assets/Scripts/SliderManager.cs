using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    public static int[] MaxTravel = { 0,500, 15, 30, 100, 400, 700, 3000 };
    public Slider slider;

    public void LevelUp()
    {
        var data = IngameManager.Instance.Data;
        data.StageLevel++;
        data.CurTravel = 0;
        data.RequireTravel = MaxTravel[data.StageLevel];
        slider.maxValue = data.RequireTravel;
        slider.value = data.CurTravel;
    }

    void Update()
    {
        slider.value = IngameManager.Instance.Data.CurTravel;
       
        if (slider.value == slider.maxValue)
        {
            Debug.Log($"stage {IngameManager.Instance.Data.StageLevel} clear");
            LevelUp();
        }
    }
}