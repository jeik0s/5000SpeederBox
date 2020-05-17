using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;

    void Update()
    {
        scoreText.text = (player.position.z + 45).ToString("0");
    }
}
