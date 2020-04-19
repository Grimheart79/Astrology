using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ZodiacCards : MonoBehaviour
{
    public Image elementImage;
    public Image seasonImage;
    public Image rulerImage;

    public TextMeshProUGUI title;

    public Sprite[] elementSprites;
    private int elementSpriteNumber = 0;
    public Sprite[] seasonSprites;
    private int seasonSpriteNumber = 0;
    public Sprite[] rulerSprites;
    private int rulerSpriteNumber = 0;

    private Zodiac aries = new Zodiac("Aries", ZodiacSeason.Spring, ZodiacElement.Fire, ZodiacRuler.Mars);     
    private Zodiac taurus = new Zodiac("Taurus", ZodiacSeason.Spring, ZodiacElement.Earth, ZodiacRuler.Venus);
    private Zodiac gemini = new Zodiac("Gemini", ZodiacSeason.Spring, ZodiacElement.Air, ZodiacRuler.Mercury);
    private Zodiac cancer = new Zodiac("Cancer", ZodiacSeason.Summer, ZodiacElement.Water, ZodiacRuler.Moon);
    private Zodiac leo = new Zodiac("Leo", ZodiacSeason.Summer, ZodiacElement.Fire, ZodiacRuler.Sun);
    private Zodiac virgo = new Zodiac("Virgo", ZodiacSeason.Summer, ZodiacElement.Earth, ZodiacRuler.Mercury);
    private Zodiac libra = new Zodiac("Libra", ZodiacSeason.Autumn, ZodiacElement.Air, ZodiacRuler.Venus);
    private Zodiac scorpio = new Zodiac("Scorpio", ZodiacSeason.Autumn, ZodiacElement.Water, ZodiacRuler.PlutoMars);
    private Zodiac sagittarius = new Zodiac("Sagittarius", ZodiacSeason.Autumn, ZodiacElement.Fire, ZodiacRuler.Jupiter);
    private Zodiac capricorn = new Zodiac("Capricorn", ZodiacSeason.Winter, ZodiacElement.Earth, ZodiacRuler.Saturn);
    private Zodiac aquarius = new Zodiac("Aquarius", ZodiacSeason.Winter, ZodiacElement.Air, ZodiacRuler.UranusSaturn);
    private Zodiac pisces = new Zodiac("Pisces", ZodiacSeason.Winter, ZodiacElement.Water, ZodiacRuler.NeptuneJupiter);

    public void ShowCard()
    {

    }

    public void CheckCard()
    {
        if (title.text == "Aries" && elementSpriteNumber == 1 && seasonSpriteNumber == 1 && rulerSpriteNumber == 5)
        {

        }
        else if (title.text == "Taurus" && elementSpriteNumber == 1 && seasonSpriteNumber == 1 && rulerSpriteNumber == 5)
        {

        }
        else if (title.text == "Gemini" && elementSpriteNumber == 1 && seasonSpriteNumber == 1 && rulerSpriteNumber == 5)
        {

        }
        else if (title.text == "Cancer" && elementSpriteNumber == 1 && seasonSpriteNumber == 1 && rulerSpriteNumber == 5)
        {

        }
        else if (title.text == "Leo" && elementSpriteNumber == 1 && seasonSpriteNumber == 1 && rulerSpriteNumber == 5)
        {

        }
        else if (title.text == "Virgo" && elementSpriteNumber == 1 && seasonSpriteNumber == 1 && rulerSpriteNumber == 5)
        {

        }
        else if (title.text == "Libra" && elementSpriteNumber == 1 && seasonSpriteNumber == 1 && rulerSpriteNumber == 5)
        {

        }
        else if (title.text == "Scorpio" && elementSpriteNumber == 1 && seasonSpriteNumber == 1 && rulerSpriteNumber == 5)
        {

        }
        else if (title.text == "Sagittarius" && elementSpriteNumber == 1 && seasonSpriteNumber == 1 && rulerSpriteNumber == 5)
        {

        }
        else if (title.text == "Capricorn" && elementSpriteNumber == 1 && seasonSpriteNumber == 1 && rulerSpriteNumber == 5)
        {

        }
        else if (title.text == "Aquarius" && elementSpriteNumber == 1 && seasonSpriteNumber == 1 && rulerSpriteNumber == 5)
        {

        }
        else if (title.text == "Pisces" && elementSpriteNumber == 1 && seasonSpriteNumber == 1 && rulerSpriteNumber == 5)
        {

        }
    }
	
    public void Btn_ChangeElement()
    {
        elementSpriteNumber++;
        if (elementSpriteNumber == 4)
        {
            elementSpriteNumber = 0;
        }
        print(elementSpriteNumber.ToString());
        elementImage.sprite = elementSprites[elementSpriteNumber];
    }

    public void Btn_ChangeSeason()
    {
        seasonSpriteNumber++;
        if (seasonSpriteNumber == 4)
        {
            seasonSpriteNumber = 0;
        }
        print(seasonSpriteNumber.ToString());
        seasonImage.sprite = seasonSprites[seasonSpriteNumber];
    }

    public void Btn_ChangeRuler()
    {
        rulerSpriteNumber++;
        if (rulerSpriteNumber == 10)
        {
            rulerSpriteNumber = 0;
        }
        print(rulerSpriteNumber.ToString());
        rulerImage.sprite = rulerSprites[rulerSpriteNumber];
    }
}

public class Zodiac
{
    public string Sign { get; set; }
    public ZodiacSeason Season { get; set; }
    public ZodiacElement Element { get; set; }
    public ZodiacRuler Ruler { get; set; }


    public Zodiac(string _name, ZodiacSeason _seas, ZodiacElement _elem, ZodiacRuler _rule)
    {
        Sign = _name;
        Season = _seas;
        Element = _elem;
        Ruler = _rule;
    }
}

public enum ZodiacSeason
{
    Spring,
    Summer,
    Autumn,
    Winter
}

public enum ZodiacElement
{
    Air,
    Earth,
    Fire,
    Water
}

public enum ZodiacRuler
{
    Sun,
    Moon,
    Mercury,
    Venus,
    Mars,
    Jupiter,
    Saturn,
    PlutoMars,
    UranusSaturn,
    NeptuneJupiter
}