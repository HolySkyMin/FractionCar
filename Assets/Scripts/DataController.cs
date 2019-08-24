using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DataController : MonoBehaviour
{
    public static DataController Instance { get; set; }

    private int m_Move = 0;
    private int m_ClickMove = 0;
    private int m_slider = 0;
    private int m_level = 0;

    public int CurTravel;
    public int DeltaTravel = 1;
    public int RequireTravel;
    public int StageLevel;
    public int CurMoney;
    public int[] AbilityValue; // 상점에서 구매할 수 있는 능력들

    private void Awake()
    {
        //PlayerPrefs.DeleteAll();
        //m_level = PlayerPrefs.GetInt("Level", 1);
        //m_Move = PlayerPrefs.GetInt("Move");
        //m_ClickMove = PlayerPrefs.GetInt("ClickMove", 1);
        //m_slider = PlayerPrefs.GetInt("Slider");

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);

        AbilityValue = new int[3];
    }
    public void SetLevel(int newLevel)
    {
        m_level = newLevel;
        PlayerPrefs.SetInt("Level", m_level);
    }
    public void AddLevel(int newLevel)
    {
        m_level += newLevel;
        SetLevel(m_level);
       
    }
    public int GetLevel()
    {
        return m_level;
    }

    public void SetMove(int newMove)
    {
        m_Move = newMove;
        PlayerPrefs.SetInt("Move", m_Move);

    }
    public void AddMove(int newMove)
    {
        m_Move += newMove;
        SetMove(m_Move);
    }
    public void SubMove(int newMove)
    {
        m_Move -= newMove;
        SetMove(m_Move);
    }
    public int GetMove()
    {
        return m_Move;
    }
    public int GetClickMove()
    {
        return m_ClickMove;
    }
    public void SetClickMove(int newClickMove)
    {
        m_ClickMove = newClickMove;
        PlayerPrefs.SetInt("ClickMove", m_ClickMove);
    }
     public void SetSlider(int newSlider)
    {
        m_slider = newSlider;
        PlayerPrefs.SetInt("Slider", m_slider);

    }
    public void AddSlider(int newSlider)
    {
        m_slider += newSlider;
        SetSlider(m_slider);
    }
    public int GetSlider()
    {
        return m_slider;
    } 

}
    

