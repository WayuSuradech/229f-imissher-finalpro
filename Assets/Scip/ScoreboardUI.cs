using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreboardUI : MonoBehaviour
{
    public GameObject scoreEntryPrefab; // Prefab สำหรับแสดงคะแนนแต่ละคน
    public Transform scoreboardContent; // Parent ของรายการคะแนน

    private Dictionary<string, GameObject> playerEntries = new Dictionary<string, GameObject>();

    public void UpdateScore(string playerName, int score)
    {
        if (playerEntries.ContainsKey(playerName))
        {
            playerEntries[playerName].GetComponentInChildren<TMP_Text>().text = playerName + ": " + score;
        }
        else
        {
            GameObject newEntry = Instantiate(scoreEntryPrefab, scoreboardContent);
            newEntry.GetComponentInChildren<TMP_Text>().text = playerName + ": " + score;
            playerEntries.Add(playerName, newEntry);
        }
    }
}