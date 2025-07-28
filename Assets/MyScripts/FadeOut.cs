using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Fadeout : MonoBehaviour
{
	[SerializeField] private TMP_Text Hogehoge;

	public void Start()
	{
		StartCoroutine(AnimationText(Hogehoge));
	}

	private IEnumerator AnimationText(TMP_Text _obj)
	{
		bool flag = true;
		float a_col = 1;
		var colortemp = _obj.color;
		while (flag)
		{
			_obj.color = new Color(colortemp.r, colortemp.g, colortemp.b, a_col);
			a_col -= 0.25f * Time.deltaTime;
			yield return new WaitForEndOfFrame();
			if (a_col < 0)
			{
				a_col = 0;
				flag = false;
			}
		}
	}
}
