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

    }
}
