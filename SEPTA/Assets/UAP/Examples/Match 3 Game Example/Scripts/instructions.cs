using UnityEngine;
using System.Collections;

public class instructions : MonoBehaviour
{
	//////////////////////////////////////////////////////////////////////////

	public void OnBackButtonPressed()
	{
		Instantiate(Resources.Load("Main Menu"));
		DestroyImmediate(gameObject);
	}

	//////////////////////////////////////////////////////////////////////////
}
