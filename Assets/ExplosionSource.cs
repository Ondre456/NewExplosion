using UnityEngine;

[RequireComponent(typeof(MassiveObject))]
public class ExplosionSource : MonoBehaviour
{
    [SerializeField] private float explosionPowerModifier = 2;

    private void OnMouseDown()
    {
        var explosion = gameObject.AddComponent<Explosion>();
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        explosion.AcceptExplosionCharacteristics(rigidbody.mass, explosionPowerModifier);
    }
}
