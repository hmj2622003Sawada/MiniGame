using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneController3 : MonoBehaviour
{
	private void Update()
	{
		if (Keyboard.current.enterKey.wasPressedThisFrame)
		{
			SceneManager.LoadScene("RuleScene");
		}
	}
}
