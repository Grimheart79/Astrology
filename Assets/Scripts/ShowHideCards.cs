using UnityEngine;

public class ShowHideCards : MonoBehaviour
{
    public GameObject[] cards;

    public void ShowCard(int cardNumber)
    {
        for (int i = 0; i < cards.Length; i++)
        {
            if (i == cardNumber)
            {
                cards[cardNumber].SetActive(true);
            }
            else
            {
                cards[i].SetActive(false);
            }
        }
    }
}
