using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SparkBallGame
{
    public class PlayerCollision : MonoBehaviour
    {
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
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            var collideObject = collision.gameObject.GetComponent<Obstacle>();
            if (!collideObject) return;

            Debug.Log("Hitting Obstacle object");
            Debug.Log("Player Died");
        }
    }
}