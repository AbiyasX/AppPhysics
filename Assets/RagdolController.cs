using Unity.VisualScripting;
using UnityEngine;

public class RagdolController : MonoBehaviour
{
    public Rigidbody[] char_rigidbodies;
    public bool is_kinematic = true;
    Animator anim;

    NPC_Script npc;
    void Start()
    {
        char_rigidbodies = GetComponentsInChildren<Rigidbody>();    
        anim = GetComponent<Animator>();
        npc = GetComponent<NPC_Script>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            is_kinematic = !is_kinematic;
        }

        npc.isfollowTarget = is_kinematic;

        if (npc.isfollowTarget)
        {
            anim.Play("Run");
        }

        anim.enabled = is_kinematic;

        foreach (Rigidbody parts in char_rigidbodies)
        {
            parts.isKinematic = is_kinematic;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("EnemeyHit");
            is_kinematic = false;
        }
    }
}
