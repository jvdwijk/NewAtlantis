using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour {

    [SerializeField]
    private Canvas loadedGames;
    private int count;

	void Start ()
    {
		foreach(Game g in SaveLoad.savedGames)
        {
            
        }
	}


}
