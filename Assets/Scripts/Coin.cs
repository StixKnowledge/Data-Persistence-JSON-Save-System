using System;
using UnityEngine;

public class Coin : MonoBehaviour, IDataPersistence
{
    [SerializeField] private string id;

    private bool collected = false;

    [ContextMenu("Generate guid for id")]
    private void GenerateGuid()
    {
        id = System.Guid.NewGuid().ToString();
    }

    public void LoadData(GameData data)
    {
        data.coinsCollected.TryGetValue(id, out collected);
        if (collected)
        {
            gameObject.SetActive(false);
        }
    }
    public void SaveData(ref GameData data)
    {
        if(data.coinsCollected.ContainsKey(id))
        {
            data.coinsCollected.Remove(id);
        }
        data.coinsCollected.Add(id, collected);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ButtonHandler.instance.OnNewGame += OnNewGame;
    }

    private void OnNewGame()
    {
        collected = false;
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            collected = true;
            GameEventsManager.instance.CoinCollected();
            gameObject.SetActive(false);
        }
    }
}
