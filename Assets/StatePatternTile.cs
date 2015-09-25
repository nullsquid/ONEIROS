using UnityEngine;
using System.Collections;

public class StatePatternTile : MonoBehaviour {

    [HideInInspector] public ITileState currentState;
    [HideInInspector] public StateOnUse onUse;
    [HideInInspector] public StateOnActive onActive;
    [HideInInspector] public StateOnIdle onIdle;

    private void Awake() {
        onIdle = new StateOnIdle(this);
        onUse = new StateOnUse(this);
        onActive = new StateOnActive(this);
        
    }
    // Use this for initialization
    void Start () {
        currentState = onIdle;
	}
	
	// Update is called once per frame
	void Update () {
        currentState.UpdateState();
	}

    
}
