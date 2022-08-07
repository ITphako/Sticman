using UnityEngine;

public class Pistol : Weapon
{
    [SerializeField] private float _maxAngle;
    [SerializeField] private float _minAngle;

    public override void Shoot(Transform shootPoint, Bullet bullet)
    {
        Quaternion angle = Quaternion.Euler(0,0, Random.Range(_minAngle, _maxAngle));
        Instantiate(bullet, shootPoint.position, angle);
    }
}

