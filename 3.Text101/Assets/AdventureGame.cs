using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
	public Text text;

	[SerializeField] private State startingState;

	private State _currentState;
    // Start is called before the first frame update
    void Start()
    {
	    _currentState = startingState;
	    text.text = _currentState.GetText();
    }

    // Update is called once per frame
    void Update()
    {
	    ManageStates();
    }

    private void ManageStates()
    {
	    var nextState = _currentState.GetNextStates();
	    if (Input.GetKeyDown(KeyCode.Alpha1))
	    {
		    _currentState = nextState[0];
	    }

	    text.text = _currentState.GetText();
    }
}
