using UnityEngine;

public class Pellets : MonoBehaviour
{
    private const int AngelOfFlight = 170;

    [SerializeField] private int _damage;
    [SerializeField] private float _speed;

    private Vector2 _directionOfFlight;

    private void Start()
    {
        _directionOfFlight = new Vector2(Mathf.Cos(AngelOfFlight * Mathf.Deg2Rad), Mathf.Sin(AngelOfFlight * Mathf.Deg2Rad));
    }

    private void Update()
    {
        transform.Translate(_directionOfFlight * _speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(_damage);

            Destroy(gameObject);
        }
    }
}