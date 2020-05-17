using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameMenager gameMenager;

    void OnTriggerEnter()
    {
        gameMenager.ComplateLevel();
    }
}
