using System.Collections.Generic;
using UnityEngine;

[System.Serializable]   // this attribute makes the class serializable by Unity, meaning its fields can be saved and loaded
public class GameData
{
    //this is where we define all the data we want to save
    public int deathCount;
    public Vector3 playerPosition; 
    public SerializableDictionary<string, bool> coinsCollected;


    //the values is defined in this constructor will be the default values
    //the game starts with when there is no data to load
    public GameData()
    {
        deathCount = 0;
        playerPosition = new Vector3(0,1.5f,0);
        coinsCollected = new SerializableDictionary<string, bool>();
    }

}
