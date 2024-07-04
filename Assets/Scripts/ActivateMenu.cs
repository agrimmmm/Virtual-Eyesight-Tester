using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ActivateMenu : MonoBehaviour
{
    public TMP_Dropdown options;
    public Button submit;
    private int index = 0;
    void Update()
    {
        index = options.value;
    }

    public void Activate()
    {
        if(index == 0)
            SceneManager.LoadScene(1);
        else if(index == 1)
            SceneManager.LoadScene(1);
        else if(index == 2)
            SceneManager.LoadScene(1);
    }
}

