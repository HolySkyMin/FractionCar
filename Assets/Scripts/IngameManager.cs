using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngameManager : MonoBehaviour
{
    public static IngameManager Instance { get; private set; }

    public FloorScroller Scroller;
    public ObjectSpawner Spawner;
    public DataController Data;
    public SliderManager TravelGage;
    public Character Chara;

    public Transform[] LinePosition;
    public GameObject StageClearPanel;
    public Text MoneyText;

    public int CurStage;
    public float RequireTravel;
    public float CurTravel;
    public float DeltaTravel;
    public bool HasRunner;
    public bool HasBreaker;
    public bool HasStun;

    public float runnerDuration = 3, breakerDuration = 3, stunDuration = 2;

    private void Awake()
    {
        Instance = this;

        Data = DataController.Instance;
    }

    // Start is called before the first frame update
    void Start()
    {
        TravelGage.Load();
        Chara.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        if(HasRunner)
        {
            runnerDuration -= Time.deltaTime;

            if(runnerDuration <= 0)
            {
                runnerDuration = 3;
                HasRunner = false;
            }
        }
        if (HasBreaker)
        {
            breakerDuration -= Time.deltaTime;

            if (breakerDuration <= 0)
            {
                breakerDuration = 3;
                HasBreaker = false;
            }
        }
        if(HasStun)
        {
            stunDuration -= Time.deltaTime;

            if(stunDuration <= 0)
            {
                stunDuration = 2;
                HasStun = false;
            }
        }

        MoneyText.text = IngameManager.Instance.Data.CurMoney.ToString();
        if (CurTravel >= RequireTravel)
            StageClearAlert();
    }

    public void StageClearAlert()
    {
        HasStun = true;
        StageClearPanel.SetActive(true);
    }

    public void MoveNextStage()
    {
        SceneChanger.Instance.ChangeScene($"Stage{CurStage + 1}");
    }
}
