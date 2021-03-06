using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SparkBallGame
{
    public class PlayerCollision : MonoBehaviour
    {
        public static UnityAction onPlayerDied = delegate { };
        private AudioSource _playerAudioSource;

        private void Start()
        {
            _playerAudioSource = GetComponent<AudioSource>();
        }

        /// <summary>
        /// The player need also to detect collectables so he can run effects and sound
        /// </summary>
        /// <param name="collision"></param>
        private void OnTriggerEnter2D(Collider2D collision)
        {
            var triggerObject = collision.GetComponent<Collectable>();
            if (!triggerObject) return;

            Debug.Log("Hitting trigger object");
            Debug.Log("Collectable Id " + triggerObject.collectableID);

            //TODO : Get their Audio Clip and Effects And play them on the player
            _playerAudioSource.PlayOneShot(triggerObject.collectableSFX);
            Instantiate(triggerObject.collectableEffect, collision.gameObject.transform.position, Quaternion.identity);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            var collideObject = collision.gameObject.GetComponent<Obstacle>();
            if (!collideObject) return;

            onPlayerDied.Invoke();
            Debug.Log("Hitting Obstacle object");
            Debug.Log("Player Died");
        }
    }
}