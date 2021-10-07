using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigator : MonoBehaviour
{
    bool levelFailed = false;
    bool levelEnd = false;
    bool mainMenu = false;

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            mainMenu = true;
        }

        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            levelFailed = true;
        }

        if (SceneManager.GetActiveScene().name == "LevelEnd")
        {
            levelEnd = true;
        }

        if (mainMenu && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Level1");
        }

        if (levelEnd && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Level1");
        }

        if (levelFailed && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Level1");
        }

    }
}