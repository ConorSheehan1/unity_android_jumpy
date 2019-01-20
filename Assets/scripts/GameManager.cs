using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {
	public void EndGame()
	{
		Debug.Log ("game over");
		SceneManager.LoadScene ("GameOver");
	}

	public void Retry()
	{
		Debug.Log ("Loading level01");
		SceneManager.LoadScene ("level01");
	}

	public void Quit()
	{
		Application.Quit ();
	}
}
