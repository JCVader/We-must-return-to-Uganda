using UnityEngine;
using System.Collections;

public class Placer : MonoBehaviour
{
    public GameObject prefab;
    public static GameObject selected;

    void OnMouseDown()
    {
        selected = prefab;
        Debug.Log("clicked");
    }
}
