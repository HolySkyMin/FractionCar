using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneButton : MonoBehaviour
{
    public void Click(string scene)
    {
        SceneChanger.Instance.ChangeScene(scene);
    }
}
