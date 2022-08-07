using UnityEngine;

public class RightBullet : Bullet
{
    private void Update()
    {
        Shoot(Vector2.right);
    }

    public override void Shoot(Vector2 direction)
    {
        transform.Translate(direction * Speed * Time.deltaTime);
    }
}
