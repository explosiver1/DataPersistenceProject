using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartMenuUIHandler : MonoBehaviour
{
    [SerializeField] public TMP_InputField pNameTextField;
    public void StartButtonPressed()
    {
        PlayerData.Instance.playerName = pNameTextField.text;
        SceneManager.LoadScene(1);
    }

    
}
