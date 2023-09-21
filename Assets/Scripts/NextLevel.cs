using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    /// <summary>
    /// This class holds functionality for loading the next level.
    /// </summary>
    public class NextLevel : MonoBehaviour
    {
        SceneLoader loadNext;

        //Grants access to the SceneLoader script
        private void Start()
        {
            loadNext = GameObject.FindGameObjectWithTag("SceneLoad").GetComponent<SceneLoader>();
        }

        //Loads the next level
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                loadNext.LoadNext();
            }
        }
    }
}
