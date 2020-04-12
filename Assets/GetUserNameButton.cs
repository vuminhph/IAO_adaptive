using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetUserNameButton : MonoBehaviour
{
    public Transform inputField;
    public GameObject GetUserName; 
    public GameObject Portal;

    void OnEnable()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(getPlayerName);
    }

    void getPlayerName()
    {
        // GameManager GM = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        // GM.Username = inputField.GetComponent<TextMeshProUGUI>().text;
        // GetUserName.SetActive(false);

        // Time.timeScale = 1;
        
        // PortalController portal = Portal.GetComponent<PortalController>();
        // portal.Load();
    }
}   
