using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreBuyButton : MonoBehaviour
{
    public void Clicked(int index)
    {
        switch(index)
        {
            case 0:
                if (IngameManager.Instance.Data.CurMoney < 100)
                    break;
                IngameManager.Instance.Data.CurMoney -= 100;
                IngameManager.Instance.Data.AbilityValue[0] += 1;
                break;
            case 1:
                if (IngameManager.Instance.Data.CurMoney < 100)
                    break;
                IngameManager.Instance.Data.CurMoney -= 100;
                IngameManager.Instance.Data.AbilityValue[1] += 1;
                break;
            case 2:
                if (IngameManager.Instance.Data.CurMoney < 100)
                    break;
                IngameManager.Instance.Data.CurMoney -= 100;
                IngameManager.Instance.Data.AbilityValue[2] += 1;
                break;
        }
    }
}
