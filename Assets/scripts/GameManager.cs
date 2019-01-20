using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public void EndGame()
	{
		Debug.Log ("game over");
		SceneManager.LoadScene ("GameOver");
	}
}
