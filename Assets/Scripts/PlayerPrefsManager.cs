using UnityEngine;
using TMPro;
using UnityEngine.InputSystem; // New Input System

public class PlayerPrefsManager : MonoBehaviour
{
    [Header("UI Reference (TextMeshPro)")]
    public TextMeshProUGUI prefsDisplayText;

    void Start()
    {
        // Initialize PlayerPrefs values
        PlayerPrefs.SetString("Username", "Alex");
        PlayerPrefs.SetInt("Score", 100);
        PlayerPrefs.SetFloat("Volume", 0.8f);
        PlayerPrefs.Save();

        // Display initial values
        LoadData();
    }

    void LoadData()
    {
        string username = PlayerPrefs.GetString("Username");
        int score = PlayerPrefs.GetInt("Score");
        float volume = PlayerPrefs.GetFloat("Volume");

        // Display only the values, no title
        prefsDisplayText.text =
            "Username: " + username +
            "\nScore: " + score +
            "\nVolume: " + volume;
    }

    void Update()
    {
        // Detect Space key using the new Input System
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // Increment score
            int currentScore = PlayerPrefs.GetInt("Score");
            currentScore += 10;

            PlayerPrefs.SetInt("Score", currentScore);
            PlayerPrefs.Save();

            // Update the TMP text
            LoadData();
        }
    }
}