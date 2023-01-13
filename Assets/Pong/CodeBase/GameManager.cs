using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Ball _ball;

    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public Text playerScoreText;
    public Text computerScroreText;
    private int _playerScore;
    private int _computerScore;



    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        ResetRound(); 
    }

    public void ComputerScores()
    {
        _computerScore++;
        this.computerScroreText.text = _computerScore.ToString();
        ResetRound();
    }

    public void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this._ball.ResetPosition();
        this._ball.AddStartingForce();
    }
}
