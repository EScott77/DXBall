using UnityEngine;

public class Enemy : MonoBehaviour
{   
    public int maxHealth = 100;
    int currentHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        
    }

    public void takeDamage(int damage){
        currentHealth -= damage;

        //player hurt animation 
        if(currentHealth <= 0){
            Die();
        }
    }

    void Die(){
        Debug.Log("Enemy died!");
        //Destroy(gameObject);
    }   


}
