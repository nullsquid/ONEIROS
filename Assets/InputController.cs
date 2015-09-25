using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {
    private static InputController inputController;
    public static InputController instance {
        get {
            if (!inputController) {
                inputController = FindObjectOfType(typeof(InputController)) as InputController;
            }
            return inputController;
        }

    }
	void Update() {
    }

    public static bool OnMouseHover() {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit) {
            return true;
        }
        return false;
    }

    /*public bool OnClick() {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (Input.GetMouseButton(0) || Input.GetT) { }
        if (hit) {
            Debug.Log(hit);
        }
    }*/


}
