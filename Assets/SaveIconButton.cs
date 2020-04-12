using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveIconButton : MonoBehaviour
{
    void OnEnable()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OpenSaveMenu);
    }

    public GameObject SaveMenu;

    void OpenSaveMenu()
    {
        SaveMenu.SetActive(true);
        Time.timeScale = 0;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().allowInput = false;
    }
}
