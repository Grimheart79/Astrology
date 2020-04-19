using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZodiacAlignment : MonoBehaviour
{
    public AudioSource audioSuccess;
    public GameObject cards;
    public Button[] signButtons;

    public Button rotateStarsButton;
    public Button rotateSignButton;
    public Button rotateMonthButton;
    public Transform picsTransform;
    public Transform signTransform;
    public Transform monthsTransform;

    float pics_lerpTime = 1f;
    float pics_currentLerpTime;
    float sign_lerpTime = 1f;
    float sign_currentLerpTime;
    float month_lerpTime = 1f;
    float month_currentLerpTime;

    float picStartRotation = 0f;
    float picEndRotation = 0f;
    float signStartRot= 0f;
    float signEndRot= 0f;
    float monthStartRot = 0f;
    float monthEndRot = 0f;

    int picsPos = 1;
    int signPos = 1;
    int monthsPos = 1;

    bool rotateStarsNow = false;
    bool rotateSignsNow = false;
    bool rotateMonthsNow = false;
    bool puzzleSolved = false;

    public void RotateStars(float rotAmount)
    {
        picsPos = rotAmount >= 0 ? picsPos + 1 : picsPos - 1;
        if (picsPos == 13)
        { 
            picsPos = 1;
        }
        if (picsPos == 0)
        {
            picsPos = 12;
        }
        picStartRotation = picsTransform.eulerAngles.z;
        picEndRotation = picsTransform.eulerAngles.z + rotAmount;
        pics_currentLerpTime = 0f;
        LockButtons(false);
        rotateStarsNow = true;
    }

    public void RotateSigns(float rotAmount)
    {
        signPos = rotAmount >= 0 ? signPos + 1 : signPos - 1;
        if (signPos == 13)
        {
            signPos = 1;
        }
        if (signPos == 0)
        {
            signPos = 12;
        }
        signStartRot = signTransform.eulerAngles.z;
        signEndRot = signTransform.eulerAngles.z + rotAmount;
        sign_currentLerpTime = 0f;
        LockButtons(false);
        rotateSignsNow = true;
    }

    public void RotateMonths(float rotAmount)
    {
        monthsPos = rotAmount >= 0 ? monthsPos + 1 : monthsPos - 1;
        if (monthsPos == 13)
        {
            monthsPos = 1;
        }
        if (monthsPos == 0)
        {
            monthsPos = 12;
        }
        monthStartRot = monthsTransform.eulerAngles.z;
        monthEndRot = monthsTransform.eulerAngles.z + rotAmount;
        month_currentLerpTime = 0f;
        LockButtons(false);
        rotateMonthsNow = true;
    }

    public void CheckIfPuzzleSolved()
    {
        Debug.Log(string.Format("Checking: Pics - {0} / Signs - {1} / Months - {2}", picsPos, signPos, monthsPos));
        if (picsPos == 9 && signPos == 8 && monthsPos == 10)
        {
            puzzleSolved = true;
            //Show the cards
            cards.SetActive(true);

            //Turn on all of the sign buttons
            for (int i = 0; i < signButtons.Length; i++)
            {
                signButtons[i].interactable = true;
            }
            //Success sound
            audioSuccess.Play();
        }
    }

    private void LockButtons(bool areButtonsInteractable)
    {
        rotateMonthButton.interactable = areButtonsInteractable;
        rotateSignButton.interactable = areButtonsInteractable;
        rotateStarsButton.interactable = areButtonsInteractable;
    }

    protected void Update()
    {
        if (rotateStarsNow)
        {
            pics_currentLerpTime += Time.deltaTime;
            if (pics_currentLerpTime > pics_lerpTime)
            {
                pics_currentLerpTime = pics_lerpTime;
                rotateStarsNow = false;
                LockButtons(true);
                CheckIfPuzzleSolved();
            }

            //Lerp!
            float perc = pics_currentLerpTime / pics_lerpTime;
            float angle = Mathf.LerpAngle(picStartRotation, picEndRotation, perc);
            picsTransform.eulerAngles = new Vector3(0, 0, angle);
        }

        if (rotateSignsNow)
        {
            sign_currentLerpTime += Time.deltaTime;
            if (sign_currentLerpTime > sign_lerpTime)
            {
                sign_currentLerpTime = sign_lerpTime;
                rotateSignsNow = false;
                LockButtons(true);
                CheckIfPuzzleSolved();
            }

            //Lerp!
            float perc = sign_currentLerpTime / sign_lerpTime;
            float angle = Mathf.LerpAngle(signStartRot, signEndRot, perc);
            signTransform.eulerAngles = new Vector3(0, 0, angle);
        }

        if (rotateMonthsNow)
        {
            //increment timer once per frame
            month_currentLerpTime += Time.deltaTime;
            if (month_currentLerpTime > month_lerpTime)
            {
                month_currentLerpTime = month_lerpTime;
                rotateMonthsNow = false;
                LockButtons(true);
                CheckIfPuzzleSolved();
            }

            //Lerp!
            float perc = month_currentLerpTime / month_lerpTime;
            float angle = Mathf.LerpAngle(monthStartRot, monthEndRot, perc);
            monthsTransform.eulerAngles = new Vector3(0, 0, angle);
        }
    }
}
