using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    private float moveHorizontal;
    private float moveVertical;
    private bool mouseClick;

    private void FixedUpdate()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
    }    

    public float GetSetVertical
    {
        get {return moveVertical; }
        set {moveVertical = value; }
    }

    public float GetSetHorizontal
    {
        get { return moveHorizontal; }
        set { moveHorizontal = value; }
    }
}
