using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildLayer : MonoBehaviour {

    [SerializeField]
    private GameObject[] layers;
    private int count;
    private Vector3 buildCamera;

    [SerializeField]
    private float layerOfset;

    void Start()
    {
        buildCamera = gameObject.transform.position;
    }

    void Update()
    {
        if (InputManager.input.OnKeyDown(InputManager.keyActions.up))
        {
            layers[count].SetActive(false);
            

            if (layers.Length -1 > count)
            {
                buildCamera.y += layerOfset;
                count++;
            }
            layers[count].SetActive(true);
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
