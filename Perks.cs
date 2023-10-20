using System;
[Flags]
public enum Perks
{
    None,
    Stealth=1<<0,
    Combat=1<<1,
    Lockpick=1<<2,
    Luck=1<<3,
    Intelligence=1<<4,
}