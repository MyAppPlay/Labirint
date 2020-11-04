using UnityEngine;


namespace Labirint
{
    public sealed class PlayerBall : Player
    {
        public PlayerBall(float speed) : base(speed)
        {

        }

        private void FixedUpdate()
        {
            Move();
        }
    }

}