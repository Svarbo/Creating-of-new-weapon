using UnityEngine;

public class Shotgun : Weapon
{
    [SerializeField] private Pellets _pelletes;

    public override void Shoot(Transform shootPoint)
    {
        Instantiate(Bullet, shootPoint.position, Quaternion.identity);
        Instantiate(_pelletes, shootPoint.position, Quaternion.identity);
    }
}
