using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galaga : MonoBehaviour
{
    public int EnemigosCount;
    public int Health = 5;
    public GameObject Shoot;
    public GameObject ShootParent;
    public GameObject MiniGame;
    public GameObject MiniGameNext;
    private void OnEnable()
    {
        StartCoroutine(ShootCoolDown());
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Cursor.visible = false;
            gameObject.transform.position = new Vector2(Input.mousePosition.x, gameObject.transform.position.y);
        }
        else
        {
            Cursor.visible = true;
        }
        if (EnemigosCount <= 0)
        {
            Cursor.visible = true;
            MiniGameNext.SetActive(true);
            MiniGame.SetActive(false);
        }
    }
    public IEnumerator ShootCoolDown()
    {
        yield return new WaitForSeconds(2);
        GameObject shootMicro = Instantiate(Shoot, gameObject.transform.position + new Vector3(0, 120, 0), Quaternion.identity);
        shootMicro.transform.SetParent(ShootParent.transform);
        StartCoroutine(ShootCoolDown());
    }
}
