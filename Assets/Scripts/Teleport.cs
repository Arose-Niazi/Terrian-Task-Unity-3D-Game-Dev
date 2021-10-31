using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
	private Vector3 _endPosition;
	
	public Text infoText;
	public GameObject infoBox;
	private void Start()
	{
		_endPosition = GameObject.Find("TeleportObject").transform.position;
	}

	void Update()
	{
		if (Input.anyKeyDown)
		{
			InputHandler();
		}
	}
	void InputHandler()
	{
		if (Input.GetKeyDown(KeyCode.Tab))
		{

			StartCoroutine(TeleportPlayer());
		}
	}

	IEnumerator TeleportPlayer()
	{
		infoText.text = "Teleporting...";
		infoBox.SetActive(true);

		transform.position = _endPosition;
		yield return new WaitForSeconds(1f);
		
		infoBox.SetActive(false);
	}
}