using UnityEngine;

public class Attack : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int dmg_;
    public GameObject src_;
    Collider2D collider_;

    private void Awake()
    {
        TryGetComponent<Collider2D>(out collider_);
    }

    public void SetDamage(int dmg,GameObject src)
    {
        //very scuffed bad code don't do this guys
        Attack c = transform.GetChild(0).gameObject.GetComponent<Attack>();
        c.dmg_ = dmg;
        c.src_ = src;
    }


    public void DealDamage()
    {
        collider_.enabled = true;
    }

    public void EndAttack()
    {
        Destroy(transform.parent.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == src_) return;
        Debug.Log("enterma" + collision.gameObject);
        if (collision.gameObject.layer == 3) //layer 3 - interactable objects
        {
            Debug.Log("ATTACKED " + collision.gameObject + src_ + dmg_);
            collision.gameObject.GetComponent<EntityData>().TryDealDamage(dmg_);
            
        }
    }
}
