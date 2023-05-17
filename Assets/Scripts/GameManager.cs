using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void PressGameStartButton()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
    public void PressAssignmentButton()
    {
        DontDestroyOnLoad (gameObject);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
