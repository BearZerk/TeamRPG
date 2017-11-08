using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInterface
{
    //Unsure on classes for the game.
    //Can create baseClass types e.g. Warrior/Archer/Mage/Beserker/etc
    //Just inherit from PlayerInterface and run public PlyaerInterface() and set all base values like a D&D P&P system.

    private string playerName;
    private int playerLevel;

    private int strength;
    private int mana;
    private int stamina;
    private int wealth;

    private int armour;
    private int hitpoints;
    private int regeneration;
    //Potentially create more values for things like:
    //poison or any damage over time value e.g. bleed
    //depending on systems of games could include things like sanity

    //For the below getters & setters on stats these can be used for more direct uses.
    //E.g. HealPlayer = SetStamina(+"X")
    //E.g. TakeDamage = SetHealth(-"Y")
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public int Mana
    {
        get { return mana; }
        set { mana = value; }
    }

    public int Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }

    public int Wealth
    {
        get { return wealth; }
        set { wealth = value; }
    }

    public int Armour
    {
        get { return armour; }
        set { armour = value; }
    }

    public int HitPoints
    {
        get { return hitpoints; }
        set { hitpoints = value; }
    }

    public int Regeneration
    {
        get { return regeneration; }
        set { regeneration = value; }
    }
}
