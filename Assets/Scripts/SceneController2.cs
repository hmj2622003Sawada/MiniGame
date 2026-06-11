using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneController2 : MonoBehaviour
{
	private void Update()
	{
		if (Keyboard.current.sKey.wasPressedThisFrame)
		{
			SceneManager.LoadScene("GameScene");
		}
	}
}
