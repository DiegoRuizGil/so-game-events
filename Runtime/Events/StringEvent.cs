/*
    This script is part of the SO Game Events Architecture Project.
    You are free to use, modify, and distribute the code as you want.
    Credit is not required, but it is always appreciated.

    Author: Diego Ruiz Gil
    https://github.com/DiegoRuizGil/so-game-events
*/

using UnityEngine;

namespace GameEvents
{
    [CreateAssetMenu(fileName = "New String Event", menuName = "Game Events/String Event")]
    public class StringEvent : BaseGameEvent<string> { }
}