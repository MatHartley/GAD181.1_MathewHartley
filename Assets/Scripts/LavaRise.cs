using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    /// <summary>
    /// This class holds functionality for loading the next level.
    /// </summary>
    public class LavaRise : MonoBehaviour
    {
        [SerializeField] public float scaleSpeed;

        // Update is called once per frame
        void Update()
        {
            transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y + scaleSpeed * Time.deltaTime);
        }
    }
}