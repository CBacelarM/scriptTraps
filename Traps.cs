//A PRIMEIRA É UMA BEAR TRAP!
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearTrap : MonoBehaviour
{

    Transform player;
    public Transform skin;

    public AudioSource audioSource;
    public AudioClip clip;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            audioSource.PlayOneShot(clip);
            skin.GetComponent<Animator>().Play("Stuck", -1);

            collision.transform.position = transform.position;
            collision.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

            collision.GetComponent<PlayerController>().skin.GetComponent<Animator>().SetBool("PlayerRun", false);
            collision.GetComponent<PlayerController>().skin.GetComponent<Animator>().Play("PlayerIdle", -1);

            GetComponent<BoxCollider2D>().enabled = false;

            player = collision.transform;

            collision.GetComponent<PlayerController>().enabled = false;

            Invoke("ReleasePlayer", 2);
        }
    }

    void ReleasePlayer()
    {
        player.GetComponent<PlayerController>().enabled = true;
    }


}

//A SEGUNDA É UMA FIRE TRAP
// TAMBÉM MOSTRA A COLISÃO E O SOM

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrap : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.GetComponent<Character>().PlayerDamage(2);
        }
    }
}

// ESSA É A PARTE DO SOM DA FIRE TRAP

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrapEvent : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;

    public void PlaySound()
    {
        audioSource.PlayOneShot(clip);
    }
}

//TERCEIRA TRAP É UMA SPIKE TRAP 1 E O SOM
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrap1 : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            collision.transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 200));
            collision.transform.GetComponent<Character>().PlayerDamage(1);
        }
    }
}

//AQUI ESTÁ O SOM
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrap1Event : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    
    void Start()
    {
        
    }


    void Update()
    {
        audioSource.PlayOneShot(clip);
    }
}


//A QUARTA É UMA SPIKE TRAP 2 E SEU SOM

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrap2 : MonoBehaviour
{
        void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.GetComponent<Character>().PlayerDamage(1);
        }
    }

}
// O SOM DA SPIKE TRAP 2 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrap2Sound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;

        void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void PlaySound()
    {
        audioSource.PlayOneShot(clip);
    }
}



