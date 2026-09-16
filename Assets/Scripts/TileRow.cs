using UnityEngine;
using UnityEngine.Rendering;

public class TileRow : MonoBehaviour
{
    public TileCell[] cells {  get; private set; }

    private void Awake()
    {
        cells = GetComponentsInChildren<TileCell>();
    }
}
