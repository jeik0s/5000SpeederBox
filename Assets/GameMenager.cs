using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 1f;


    public GameObject complateLevelUi;


    public void ComplateLevel()
    {
        complateLevelUi.SetActive(true);
        Debug.Log("DUPA");
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("GAME OVER");
            FindObjectOfType<Movment>().ForwardSpeed = 50;
            FindObjectOfType<Movment>().rightleftSpeed = 0;
            gameHasEnded = true;
            Invoke("Reset", restartDelay);
        }
    }

    private void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
