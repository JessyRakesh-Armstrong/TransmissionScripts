using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;
        public Transform shotSpawn;
        public float fireRate;
        public float nextFire;
        public GameObject shot;

        public Boolean isPlayer;

        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (gameObject.tag == "Spitter" && isPlayer && Time.time>fireRate)
            {
                if (Input.GetButton("Fire1"))
                {
                    nextFire = Time.time + fireRate;//makes sure that you cant output a stream of bullets
                    Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                }
            }

            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");

            }
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            //if (other.tag == "Player") return;//this way the boundary and asteroid don't break each other
            //Destroy(other.gameObject);
            //Destroy(gameObject);//destroys thing this script is attached to
        }

            private void FixedUpdate()
        {
            // Read the inputs.
            //bool crouch = Input.GetKey(KeyCode.LeftControl);
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            m_Character.Move(h, /*crouch,*/ m_Jump);
            m_Jump = false;
        }
    }
}
