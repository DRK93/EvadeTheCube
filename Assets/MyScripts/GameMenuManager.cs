using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace MyScripts
{
    public class GameMenuManager : MonoBehaviour
    {
        public Button startGame;
        public Button leaveGame;
        public GameObject mainMenuBackground;

        private void Start()
        {
            PauseGame();
        }

        public void PlayGame()
        {
            HideMenu();
        }

        public void QuitGame()
        {
            Application.Quit();
        }

        public void PauseGame()
        {
            ShowMenu();
        }

        private void ShowMenu()
        {
            Time.timeScale = 0f;
            mainMenuBackground.SetActive(true);
            startGame.gameObject.SetActive(true);
            leaveGame.gameObject.SetActive(true);
        }
        private void HideMenu()
        {
            mainMenuBackground.SetActive(false);
            startGame.gameObject.SetActive(false);
            leaveGame.gameObject.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}

