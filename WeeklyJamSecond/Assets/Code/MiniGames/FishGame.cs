using UnityEngine;
using UnityEngine.UI;

public class FishGame : MonoBehaviour
{
    public int FixPos;
    public Image Buton;
    public int State; // 0-right, 1-left
    public float NowPosition;
    public GameObject Fish;
    Vector3 FishPos;
    public GameObject NextPage;
    private void Start()
    {
        FishPos = Fish.transform.position;
        NowPosition = FishPos.x;
    }
    void Update()
    {
        if (State == 0)
        {
            NowPosition += 2;
        }
        if (State == 1)
        {
            NowPosition -= 2;
        }
        if (NowPosition < 50 + FixPos)
        {
            State = 0;
        }
        if (NowPosition > 750 + FixPos)
        {
            State = 1;
        }
        if (NowPosition > 320 + FixPos && NowPosition < 480 + FixPos)
        {
            Buton.color = Color.green;
        }
        else
        {
            Buton.color = Color.white;
        }
        FishPos.x = NowPosition;
        Fish.transform.position = FishPos;
    }
    public void Fix()
    {
        if (NowPosition > 320 + FixPos   && NowPosition < 480 + FixPos)
        {
            NextPage.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
