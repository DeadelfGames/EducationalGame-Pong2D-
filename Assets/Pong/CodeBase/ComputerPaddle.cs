using UnityEngine;

public class ComputerPaddle : Paddle
{
    [SerializeField] Rigidbody2D _ball;
    private void FixedUpdate()
    {
        if (this._ball.velocity.x > 0.0f)
        {
            if (this._ball.position.y > this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
            else if (this._ball.position.y < this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        }

        else
        {
            if (this._ball.velocity.y > 0.0f)
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
            else if (this._ball.velocity.y < 0.0f)
            {
                _rigidbody.AddForce(Vector2.up * this.speed); 
            }
        }
    }
}