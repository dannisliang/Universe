using UnityEngine;
using System.Collections;

public class Magnetic : MonoBehaviour {
    /// <summary>
    /// 引力设置
    /// </summary>
    public LayerMask m_MagneticLayers;
    public Vector3 m_Position;
    public float m_Radius;
    public float m_Force;
    void FixedUpdate()
    {
        Collider[] colliders;
        Rigidbody rigidbody;
        colliders = Physics.OverlapSphere(transform.position + m_Position, m_Radius, m_MagneticLayers);
        foreach (Collider collider in colliders)
        {
            rigidbody = (Rigidbody)collider.gameObject.GetComponent(typeof(Rigidbody));
            if (rigidbody == null)
            {
                continue;
            }
           // var distance = Vector3.Distance(rigidbody.transform.position, transform.position);
            Vector3 newDirection = transform.position - rigidbody.transform.position;
           // rigidbody.AddExplosionForce(m_Force * -1, transform.position + m_Position, m_Radius);
            rigidbody.AddForce(newDirection);
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position + m_Position, m_Radius);
    }
}
