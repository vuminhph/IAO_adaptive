using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PauseScreenController : MonoBehaviour
{
    PlayerController player;
    GameManager Gm;
    TextMeshProUGUI score;
    FindChildrenWithTag ChildrenGetter;

    void Start() 
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        Gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        ChildrenGetter = GetComponent<FindChildrenWithTag>();
        score = ChildrenGetter.GetChildWithName(transform, "Score").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = Gm.score.ToString();
    }

    private void OnEnable() {
        player.allowInput = false;
    }

    private void OnDisable() {
        player.allowInput = true;   
    }
}
