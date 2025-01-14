using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSource : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.AddComponent<Explosion>();
    }
}
