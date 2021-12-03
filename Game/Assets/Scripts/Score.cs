using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text scoreText;

    void Update()
    {
        scoreText.text = Player.position.z.ToString("0");
        //works ovo dole

       /* if (scoreText.text == Player.position.z.ToString("666"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }*/
    }
}
