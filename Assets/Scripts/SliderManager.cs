using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    public static int[] MaxTravel = { 5, 15, 30, 100, 400, 700, 3000 };
    public Slider slider;
    public DataController dataController;
    // Start is called before 
    private int level;
    public bool isLevel;
    public int CurrentStage;

    void Awake()
    {
        CurrentStage = 0;
        level = dataController.GetLevel();
    }
    public void LevelUp()
    {
        dataController.SetSlider(0);
        dataController.AddLevel(1);
        CurrentStage += 1;

    }
    void Update()
    {
        slider.maxValue = MaxTravel[CurrentStage];
        slider.value = dataController.GetSlider();
       
        if (slider.value == slider.maxValue)
        {
            Debug.Log("stage  clear");
            isLevel = true;
            LevelUp();
            isLevel = false;
            
        }
    }
}
// Update is called once per frame


