using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    [SerializeField] float speed = 200.0f;
    public new Rigidbody2D rigidbody { get; private set; }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();

    }
    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }
    public void ResetPosition()
    {
        rigidbody.position = Vector2.zero;
        rigidbody.velocity = Vector2.zero;
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(0.5f, 1.0f) : Random.Range(-1.0f, -0.5f);

        Vector2 directiron = new Vector2(x, y);

        rigidbody.AddForce(directiron * this.speed);
    }

}
