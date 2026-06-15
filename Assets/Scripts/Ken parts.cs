using UnityEditor.U2D.Aseprite;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ken : MonoBehaviour
{
	[SerializeField] GameObject HyogoPrefab;
	[SerializeField] GameObject OsakaPrefab;
	[SerializeField] GameObject KyotoPrefab;
	[SerializeField] GameObject NaraPrefab;
	[SerializeField] GameObject ShigaPrefab;
	[SerializeField] GameObject WakayamaPrefab;
	[SerializeField] GameObject MiePrefab;

	[SerializeField] GameObject[] kenPrefabs;

	bool check = false;
	
	PolygonCollider2D polygonCollider;


	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	private void Update()
	{
		if (Keyboard.current.spaceKey.wasPressedThisFrame && check == false)
		{
			int rnd = Random.Range(0, kenPrefabs.Length);
			Instantiate(kenPrefabs[rnd]);
			check = true;
			//if (rnd == 1)
			//{
			//	Instantiate(HyogoPrefab);
			//	check = true;
			//}
			//if (rnd == 2)
			//{
			//	Instantiate(OsakaPrefab);
			//	check = true;
			//}
			//if (rnd == 3)
			//{
			//	Instantiate(KyotoPrefab);
			//	check = true;
			//}
			//if (rnd == 4)
			//{
			//	Instantiate(NaraPrefab);
			//	check= true;
			//}
			//if (rnd == 5)
			//{
			//	Instantiate(ShigaPrefab);
			//	check = true;
			//}
			//if (rnd == 6)
			//{
			//	Instantiate(WakayamaPrefab);
			//	check = true;
			//}
			//if (rnd == 7)
			//{
			//	Instantiate(MiePrefab);
			//	check = true;
			//}
			

		}
		if (Keyboard.current.enterKey.wasPressedThisFrame && check == true )
		{
			check = false;
		
		}
	}
}
