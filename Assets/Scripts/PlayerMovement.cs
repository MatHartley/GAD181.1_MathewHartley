using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MathewHartley
{
    /// <summary>
    /// This class holds all the variables and functionality for moving our character around our game world.
    /// </summary>
    public class PlayerMovement : MonoBehaviour
    {
        public float moveSpeed;
        public float jumpForce;
        public Transform ceilingCheck;
        public Transform groundCheck;
        public LayerMask groundObjects;
        public float checkRadius;
        public int maxJump;
        
        private float moveDirection;
        private Rigidbody2D playerCharacter;
        private bool facingRight = true;
        private bool isJumping = false;
        private bool isGrounded;
        private int jumpCount;

        SceneLoader loadDeath;

        // Awake is called after all objects are instantialized
        private void Awake()
        {
            playerCharacter = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            jumpCount = maxJump;
            loadDeath = GameObject.FindGameObjectWithTag("SceneLoad").GetComponent<SceneLoader>();
        }

        // Update is called once per frame
        void Update()
        {
            GetInputs();

            AnimateCharacter();
        }

        //Fixed Update can be called multiple times per update tick so handles physics better than update
        private void FixedUpdate()
        {
            //Check if player character is grounded
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundObjects);

            if (isGrounded)
            {
                jumpCount = maxJump;
            }

            MoveCharacter();
        }

        //Animates player sprite
        private void AnimateCharacter()
        {
            if (moveDirection > 0 && !facingRight)
            {
                FlipCharacter();
            }
            else if (moveDirection < 0 && facingRight)
            {
                FlipCharacter();
            }
        }

        //Moves player character
        private void MoveCharacter()
        {
            playerCharacter.velocity = new Vector2(moveDirection * moveSpeed, playerCharacter.velocity.y);

            if(isJumping)
            {
                playerCharacter.AddForce(new Vector2(0f, jumpForce));
                jumpCount--;
            }
            isJumping = false;
        }

        //Gets player inputs
        private void GetInputs()
        {
            moveDirection = Input.GetAxis("Horizontal"); //returns -1 to 1

            if(Input.GetButtonDown("Jump") && jumpCount > 0)
            {
                isJumping = true;
            }
        }

        //Flips player sprite facing direction
        private void FlipCharacter()
        {
            facingRight = !facingRight;
            transform.Rotate(0f, 180f, 0f);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Lava"))
            {
                Destroy(gameObject);
                loadDeath.LoadDeath();

            }
        }
    }
}
