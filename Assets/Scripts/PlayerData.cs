using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerData", menuName = "Assignment/Player Data")]
public class PlayerData : ScriptableObject
{
    public string playerName;
    public int playerLevel;
    public float playerHealth;
}