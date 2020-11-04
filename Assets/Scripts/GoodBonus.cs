using UnityEngine;


namespace Labirint
{
    public sealed partial class GoodBonus : InteractiveObject, IFly, IFlicker
    {
        #region Fields

        [SerializeField] private float _minLengthFly = 1.0f;
        [SerializeField] private float _maxLengthFly = 5.0f;

        private float _lengthFly;

        private Material _material;
        private DisplayBonuses _displayBonuses;

        #endregion  


        #region UnityMetods

        private void Awake()
        {
            _displayBonuses = new DisplayBonuses();
        }

        private void Start()
        {
            _material = GetComponent<Renderer>().material;
            _lengthFly = Random.Range(_minLengthFly, _maxLengthFly);
        }

        #endregion


        #region Metods

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b,
                Mathf.PingPong(Time.time, 1.0f));
        }

        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _lengthFly),
                transform.localPosition.z);
        }

        protected override void Interaction()
        {
            _displayBonuses.Display(5);
            if (--GameController.GoodBonuses <= 0)
                _displayBonuses.Display("Все бонусы собраны");
        }

        #endregion
    }
}