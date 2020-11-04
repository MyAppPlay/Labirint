using UnityEngine;


namespace Labirint
{
    public class LabirintGenerator
    {
        private bool[,] _matrix;

        public bool[,] GetMatrix(int raws, int columns)
        {
            _matrix = new bool[raws, columns];
            var r = 1;
            var c = 1;
            _matrix[r, c] = true;
            var complete = false;
            var randomR = 0; ;
            var randomC = 0;

            while (!complete)
            {
                randomR = Random.Range(-1, 2);
                if (randomR == 0)
                    randomC = Random.Range(-1, 2);
                else
                {
                    complete = true;
                    continue;
                }

                if (randomC != 0)
                    complete = true;
            }

            r += randomR;
            c += randomC;
            _matrix[r, c] = true;

            return _matrix;
        }


    }

}