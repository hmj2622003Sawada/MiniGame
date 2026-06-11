using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SceneController : MonoBehaviour
{
	private void Update()
	{
		if (Keyboard.current.enterKey.wasPressedThisFrame)
		{
			SceneManager.LoadScene("SceneRule");
		}
	}
}
