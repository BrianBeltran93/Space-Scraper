using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    [SerializeField] private List<GameObject> breakablePieces;

    private float _timer = 0;
    
    private const float TimeToBreak = 2;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in breakablePieces)
        {
            item.SetActive(false);
        }
        
    }

    private void Break()
    {
        _timer += Time.deltaTime;

        if (_timer >= TimeToBreak)
        {
            foreach (var item in breakablePieces)
            {
                item.SetActive(true);
                item.transform.parent = null;
            }
        
            gameObject.SetActive(false);
        }
        
    }
}
