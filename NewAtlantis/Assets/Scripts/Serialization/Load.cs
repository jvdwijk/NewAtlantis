using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour {

    private int count;
    private bool uiEnabled = false;

    void Awake()
    {
        SaveLoad.Load();
    }

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.BeginVertical();
        GUILayout.FlexibleSpace();

        print(SaveLoad.savedGames.Count);

        if (uiEnabled)
        {
            foreach (Game g in SaveLoad.savedGames)
            {
                GUILayout.Box("test");
                GUILayout.Space(20);
                if(g != null)
                {
                    if (GUILayout.Button(g.ToString()))
                    {
                        Game.current = g;
                    }
                }
            }
        }

        GUILayout.FlexibleSpace();
        GUILayout.EndVertical();
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}
