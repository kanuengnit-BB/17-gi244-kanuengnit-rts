using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   [SerializeField] private string NewScene;

   public void NewGame()
   {
      SceneManager.LoadScene(NewScene);
   }
   public  void ExitGame()
   {
    Application.Quit();  
   }
}
