using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class BouncySurface : MonoBehaviour
{
    public float bounceStrenght = 1f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;

            ball.rigidbody.AddForce(-normal * bounceStrenght, ForceMode2D.Impulse);
        }
    }
}
