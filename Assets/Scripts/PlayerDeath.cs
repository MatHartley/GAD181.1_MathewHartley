using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    /// <summary>
    /// This class holds functionality for player death.
    /// </summary>
    public class PlayerDeath : MonoBehaviour
    {
        SceneLoader loadDeath;

        //Grants access to the SceneLoader script
        private void Start()
        {
            loadDeath = GameObject.FindGameObjectWithTag("SceneLoad").GetComponent<SceneLoader>();
        }

        //Loads the player death screen
        private void OnTriggerEnter2D(Collider2D collision)
        {
                loadDeath.LoadDeath();
        }
    }
}
