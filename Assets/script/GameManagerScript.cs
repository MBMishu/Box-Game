using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 10f;

    public GameObject complteLevelUI;
    public void CompleteLevel() {
        complteLevelUI.SetActive(true);
    }

    public void EndGame()
    {


        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("restart", restartDelay);
        }
    }

    private void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
