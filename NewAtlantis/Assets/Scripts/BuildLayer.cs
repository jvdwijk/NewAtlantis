using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildLayer : MonoBehaviour {
    [SerializeField]
    private float layerOfset;
    [SerializeField]
    private GameObject[] layers;
    private int count;
    private Vector3 buildCamera;
    public static GameObject currentLayer;
    
    void Awake()
    {
        currentLayer = layers[0];
    }

    void Update()
    {
        buildCamera = gameObject.transform.position;

        if (InputManager.input.OnKeyDown(InputManager.keyActions.up))
        {
            layers[count].SetActive(false);

            if (layers.Length -1 > count)
            {
                buildCamera.y += layerOfset;
                count++;
            }
            layers[count].SetActive(true);
            currentLayer = layers[count];
        }
        if (InputManager.input.OnKeyDown(InputManager.keyActions.down))
        {
            layers[count].SetActive(false);

            if (count > 0)
            {
                buildCamera.y -= layerOfset;
                count--;
            }
            layers[count].SetActive(true);
        }

        gameObject.transform.position = buildCamera;
    }
}
