using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
	[TextArea(14,10)][SerializeField] private string text;
	[SerializeField] private State[] nextStates;

	public string GetText()
	{
		return text;
	}

	public State[] GetNextStates()
	{
		return nextStates;
	}
}
