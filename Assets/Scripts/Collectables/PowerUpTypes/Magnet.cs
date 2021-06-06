using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SparkBallGame
{
    public class Magnet : PowerUp
    {
        protected Collider2D[] returnColls = new Collider2D[20];
        public float radius;
        public LayerMask coinsLayer;
   
        private void Start()
        {
            //_player = GameObject.FindGameObjectWithTag("Player");
        }

        private void Update()
        {
            if (powerUpCollected)
            {

                int nb = Physics2D.OverlapCircleNonAlloc(player.transform.position, radius, returnColls, coinsLayer);

                for (int i = 0; i < nb; ++i)
                {
                    returnColls[i].transform.position = Vector2.MoveTowards(returnColls[i].transform.position, player.transform.position, 30f * Time.deltaTime);
                }
            }
        }

    }
}