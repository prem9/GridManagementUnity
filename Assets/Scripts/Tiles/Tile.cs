using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Tile : MonoBehaviour
{
    [SerializeField] protected SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;

    public virtual void Init(int x, int y)
    {
        // Base initialization logic can be implemented here if needed
    }

    void OnMouseEnter()
    {
        _highlight.SetActive(true);
        Debug.Log("Mouse Entered");
    }
    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }
}
