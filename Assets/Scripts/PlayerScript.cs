using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Camera mainCamera;
    [SerializeField]
    private GameObject pizzaPrefab;
    // private  gamefieldSize;
    public int score = 0;

    void Start()
    {
        mainCamera = Camera.main;
        // var pizza = Instantiate(pizzaPrefab);
        StartCoroutine(SpawnEnemy());
    }
    
    void Update()
    {
        Click();
    }

    private IEnumerator SpawnEnemy()
    {

        while (true)
        {
            // Vector3 pos = new Vector3(
            //     Random.Range(((-1) * gamefieldSize.x), (gamefieldSize.x)),
            //     Random.Range(((-1) * gamefieldSize.y), (gamefieldSize.y)),
            //     0);
            
            Vector3 pos = new Vector3(
                Random.Range(-6, 6),
                Random.Range(-3, 3),
                0);
            
            var pizza = Instantiate(pizzaPrefab, pos, Quaternion.identity);
            var p = 3.14f;
            pizza.transform.rotation = Quaternion.EulerAngles(0,0,Random.Range(0, 2 * p));
            yield return new WaitForSeconds(2);
        }
    }
    
    void Click()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
        RaycastHit2D hit = Physics2D.Raycast(mainCamera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        
        if(hit.collider != null)
        {
            score++;
        //         Destroy(hit.collider.gameObject);
        }
        }
    }
}
