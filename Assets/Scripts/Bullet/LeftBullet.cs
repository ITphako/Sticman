using UnityEngine;

public class LeftBullet : Bullet
{
    private void Update()
    {
        Shoot(Vector2.left);
    }

    public override void Shoot(Vector2 direction)
    {
        transform.Translate(direction * Speed * Time.deltaTime);
    }
}
