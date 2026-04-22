using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;

public class DeathCountText : MonoBehaviour, IDataPersistence
{
    private int deathCount = 0;

    private TextMeshProUGUI deathCountText;

    private void Awake()
    {
        deathCountText = GetComponent<TextMeshProUGUI>();
    }

    //dito nagloload
    public void LoadData(GameData data)
    {
        this.deathCount = data.deathCount;
    }

    public void SaveData(ref GameData data)
    {
        data.deathCount = this.deathCount;
    }

    private void Start()
    {
        // subscribe to events
        ButtonHandler.instance.OnNewGame += OnNewGame;
        GameEventsManager.instance.onPlayerDeath += OnPlayerDeath;
    }
    private void OnNewGame()
    {
        deathCount = 0;
    }

    private void OnDestroy()
    {
        // unsubscribe from events
        GameEventsManager.instance.onPlayerDeath -= OnPlayerDeath;
    }

    private void OnPlayerDeath()
    {
        deathCount++;
    }

    private void Update()
    {
        deathCountText.text = "Death :" + deathCount;
    }
}