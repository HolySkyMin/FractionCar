using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    public Text MoneyText;

    void Update()
    {
        MoneyText.text = IngameManager.Instance.Data.CurMoney.ToString();
    }
}
