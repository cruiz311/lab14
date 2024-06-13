using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    public Player player;
    public GameObject enemy;

    public Button fireButton;
    public Button waterButton;
    public Button attackButton;

    void Start()
    {
        fireButton.onClick.AddListener(() => player.EscogerStrategy(new FireAtack()));
        waterButton.onClick.AddListener(() => player.EscogerStrategy(new WaterAtack()));
        attackButton.onClick.AddListener(() => player.Attack(enemy));
    }
}
