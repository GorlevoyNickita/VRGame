using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayUI : MonoBehaviour
{

    [Header("Main Menu Buttons")]
    public Button playButton;
    void Start()
    {
       playButton.onClick.AddListener(PlayGame);
    }

   
      public void PlayGame()
    {

        SceneManager.LoadScene("SpaceWar_Main");
    }

   

   
   
}
