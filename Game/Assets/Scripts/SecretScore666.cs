using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecretScore666 : MonoBehaviour
{
    public Transform Player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        if (scoreText.text == Player.position.z.ToString("666"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
    }
}
