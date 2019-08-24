using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    public static int[] MaxTravel = { 0, 500, 15, 30, 100, 400, 700, 3000 };
    public Text MaxTravelText, TravelLeftText;
    public Slider slider;

    public void Load()
    {
        slider.maxValue = IngameManager.Instance.RequireTravel;
        MaxTravelText.text = IngameManager.Instance.RequireTravel.ToString("N0");
        slider.value = 0;
    }

    void Update()
    {
        slider.value = IngameManager.Instance.CurTravel;
        TravelLeftText.text = (IngameManager.Instance.RequireTravel - IngameManager.Instance.CurTravel).ToString("N0");
    }
}