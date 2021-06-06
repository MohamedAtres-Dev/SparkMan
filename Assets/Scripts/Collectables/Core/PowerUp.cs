using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SparkBallGame
{
    public class PowerUp : Collectable
    {
        //ToDO: make common power up logic here

        public IntValue powerUpTimer;
        protected bool powerUpCollected;
        private int tempTimer;

        protected override void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                player = collision.gameObject;
                powerUpCollected = true;
                transform.localScale = Vector3.zero;
                tempTimer = powerUpTimer.value;
                StartCoroutine(ActivateTime());
            }
            
        }
        IEnumerator ActivateTime()
        {
            ActivatePowerUp();
            while (tempTimer > 0)
            {
                yield return new WaitForSeconds(1f);
                tempTimer--;
                Debug.Log("Remaining Time" + tempTimer);
            }
            powerUpCollected = false;
            DeactivatePowerUp();
            gameObject.SetActive(false);
        }

        protected virtual void ActivatePowerUp()
        {
            Debug.Log("Power Up " + collectableID + " is Active Now");
        }

        protected virtual void DeactivatePowerUp()
        {
            Debug.Log("Power Up " + collectableID + " is Deactive Now");
        }
    }
}