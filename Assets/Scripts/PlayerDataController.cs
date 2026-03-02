using UnityEngine;
using TMPro;

public class PlayerDataController : MonoBehaviour
{
    public PlayerData playerData;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI healthText;

    void Start()
    {
        nameText.text = "Name: " + playerData.playerName;
        levelText.text = "Level: " + playerData.playerLevel.ToString();
        healthText.text = "Health: " + playerData.playerHealth.ToString();
    }
}