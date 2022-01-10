using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private static int _nextLevelIndex;
    private Enemy[] _enemies;

   private void OnEnable()
   {
       _enemies = FindObjectsOfType<Enemy>();
   }

    void Update()
    {
        foreach (Enemy enemy in _enemies)
        {
            if (enemy != null)
                return;
        }
        Debug.Log("You killed all enemies");

        _nextLevelIndex++;
        string nextLevelName = "Level1" + _nextLevelIndex;
        SceneManager.LoadScene(nextLevelName);
    }
}
