using System.Collections;
using UnityEngine;

[System.Serializable]
public class Game {

    public static Game current;
    public Base mainBase;

	public Game ()
    {
        mainBase = new Base();
    }
}
