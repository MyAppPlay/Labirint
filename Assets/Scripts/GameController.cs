using UnityEngine;


namespace Labirint
{
    public sealed class GameController : MonoBehaviour
    {
        private InteractiveObject[] _interactiveObjects;
        public static int GoodBonuses;

        private void Awake()
        {
            _interactiveObjects = FindObjectsOfType<InteractiveObject>();

            GoodBonuses = GetGoodBonuses(GoodBonuses);
        }

        private int GetGoodBonuses(int GB)
        {
            foreach (GoodBonus goodBonus in _interactiveObjects)
            {
                GB++;
            }
            return GB;
        }

        private void Update()
        {
            for (var i = 0; i < _interactiveObjects.Length; i++)
            {
                var interactiveObject = _interactiveObjects[i];

                if (interactiveObject == null)
                {
                    continue;
                }

                if (interactiveObject is IFly flay)
                {
                    flay.Fly();
                }
                if (interactiveObject is IFlicker flicker)
                {
                    flicker.Flicker();
                }
                if (interactiveObject is IRotation rotation)
                {
                    rotation.Rotation();
                }
            }
        }
    }
}