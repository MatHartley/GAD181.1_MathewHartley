using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    /// <summary>
    /// This class holds all the variables and functionality for moving our character around our game world.
    /// </summary>
    public class SimpleCharacterController : MonoBehaviour
    {
        [SerializeField] private float horizontalInputValue; // The value of our horizontal input axis.

		private Rigidbody2D charRigidbody2D;
		[SerializeField] public float charSpeed;
		[SerializeField] public float charJump;
		private bool isGrounded;
		
		/// <summary>
		/// initializes the Rigidbody2d component
		/// </summary>
        private void Start()
		{
			charRigidbody2D = GetComponent<Rigidbody2D>();
		}
		
		/// <summary>
		/// basic movement script allowing for horizontal movement and jumping
		/// </summary>
		private void Update()
        {
			//store the horizontal keyboard input
			horizontalInputValue = Input.GetAxisRaw("Horizontal");
			//use horizontal input to move character
            transform.position += Time.deltaTime * charSpeed * new Vector3(horizontalInputValue, 0);
		
			//checks if the character is currently moving vertically
			if (charRigidbody2D.velocity.y == 0)
			{
				//character is declared to be on the ground
				isGrounded = true;
			}
			else
			{
				//character is declared to be not on the ground
				isGrounded = false;
			}
			
			//get button press input space bar and whether the character is grounded
			if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
			{
				//character jumps
				charRigidbody2D.velocity = new Vector3(charRigidbody2D.velocity.x, charJump);
			}
        }
    }
}