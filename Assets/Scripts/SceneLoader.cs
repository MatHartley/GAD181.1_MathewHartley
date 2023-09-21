using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MathewHartley
{
    /// <summary>
    /// This class holds functionality for scene transitions on level completion or death.
    /// </summary>
    public class SceneLoader : MonoBehaviour
    {
        public void LoadMenu()
        {
            SceneManager.LoadScene("MainMenu");
        }

        public void LoadLevel01()
        {
            SceneManager.LoadScene("Level_01");
        }

        public void LoadDeath()
        {
            SceneManager.LoadScene("YouDied");
        }

        public void LoadNext()
        {
            SceneManager.LoadScene("YouWin"); //placeholder for prototype build
        }
    }
}
