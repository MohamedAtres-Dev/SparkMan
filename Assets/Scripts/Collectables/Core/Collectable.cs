using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SparkBallGame
{
    public abstract class Collectable : MonoBehaviour
    {
        public string collectableID;
        public AudioClip collectableSFX;
        public GameObject collectableEffect;

        protected virtual void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                gameObject.SetActive(false);
            }
        }

    }
}