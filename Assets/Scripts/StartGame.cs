using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Transform gameBoardTrans;
    public Button gameStartBtn;
    private Vector3 gameBoardStartTrans;
    private Vector3 gameBoardEndTrans;
 
    private bool hasGameStarted = false;
    float gameStarted_lerpTime = 1f;
    float gameStarted_currentLerpTime;

    private void Start()
    {
        gameBoardStartTrans = new Vector3(gameBoardTrans.position.x, gameBoardTrans.position.y, gameBoardTrans.position.z);
        gameBoardEndTrans = new Vector3(960f, gameBoardTrans.position.y, gameBoardTrans.position.z);
    }

    void Update()
    {
        if (hasGameStarted)
        {
            gameStarted_currentLerpTime += Time.deltaTime;
            if (gameStarted_currentLerpTime > gameStarted_lerpTime)
            {
                gameStarted_currentLerpTime = gameStarted_lerpTime;
                hasGameStarted = false;
            }

            //Lerp!
            float t = gameStarted_currentLerpTime / gameStarted_lerpTime;
            t = t * t * t * (t * (6f * t - 15f) + 10f);
            gameBoardTrans.position = Vector3.Lerp(gameBoardStartTrans, gameBoardEndTrans, t);
        }
    }

    public void MoveGameBoard()
    {
        hasGameStarted = true;
        gameStartBtn.interactable = false;
    }
}
