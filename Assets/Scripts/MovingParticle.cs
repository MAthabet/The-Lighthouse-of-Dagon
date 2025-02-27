using UnityEngine;
using System.Collections;

public class MovingParticle : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private ParticleSystem[] collideParticles;
    [SerializeField] private GameObject player;
    private ParticleSystem particleSystemComponent;
    private bool isMoving = false;
    [SerializeField] GameObject boss;
    void Start()
    {
        particleSystemComponent = GetComponent<ParticleSystem>();
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    void Update()
    {
        if (isMoving && particleSystemComponent != null && player != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, boss.transform.position, moveSpeed * Time.deltaTime);

            transform.LookAt(boss.transform.position);
        }
    }
    //private void OnCollisionEnter(Collision collsion)
    //{
    //        float damage = player.GetComponent<PlayerStats>().currentMagicCharge;
    //        if (damage < 60) damage *= 1.5f;
    //        else if(damage < 90) damage *= 2.0f;
    //        else if (damage < 99)  damage *= 3.0f;
    //        else damage *= 3.33f;
    //        boss.GetComponent<BossLogic>().TakeDamage(damage);
    //        Debug.Log("Damage: " + damage);
    //        player.GetComponent<PlayerStats>().currentMagicCharge = 0;
    //        UiManager.Instance.UpdateMagicCharge();
    //        Destroy(gameObject);
    //}
  
    public void StartMoving()
    {
        isMoving = true;
    }

  
}
