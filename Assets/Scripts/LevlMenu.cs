using UnityEngine;
using UnityEngine.SceneManagement;

public class LevlMenu : MonoBehaviour   
{
   public void LevlOne()
   {
        SceneManager.LoadScene("Game_One");
    }

    public void LevlTwoo()
    {
        SceneManager.LoadScene("Game_Twoo");
    }
}
