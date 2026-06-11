using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ItemController : MonoBehaviour
{
	Rigidbody2D rigid2D;
	float RotateSpeed = 10.0f;
	bool dropped = false;
	PolygonCollider2D polygonCollider;

	

	private void Start()
	{
		rigid2D = GetComponent<Rigidbody2D>();
		polygonCollider = transform.GetChild(0).GetComponent<PolygonCollider2D>();
		polygonCollider.enabled = false;
	}
	private void Update()
	{
		if (dropped == false)
		{
			if (Keyboard.current.aKey.wasPressedThisFrame)
			{
				transform.Translate(-0.5f, 0, 0); // 左１
			}
			if (Keyboard.current.dKey.wasPressedThisFrame)
			{
				transform.Translate(0.5f, 0, 0); // 右1
			}
			if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
			{
				Transform child = transform.GetChild(0);
				child.Rotate(Vector3.forward, RotateSpeed);
			}
			if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
			{
				Transform child = transform.GetChild(0);
				child.Rotate(-Vector3.forward, RotateSpeed);
			}
			if (Keyboard.current.enterKey.wasPressedThisFrame)
			{
				// 落下
				rigid2D.bodyType = RigidbodyType2D.Dynamic;

				polygonCollider.enabled = true;
				// 操作不能
				dropped = true;
			}
		}
		// 画面外破棄
		if (transform.position.y < -5.0f)
		{
			Destroy(gameObject);
			SceneManager.LoadScene("TitleScene");
		}
	}
}
