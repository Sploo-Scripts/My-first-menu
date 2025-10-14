using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class Speedboost
    {
        public static void SpeedBoost()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 7.8f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 3.9f;
        }

        public static void speedboostRG()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                SpeedBoost();
            }
        }

        public static void compspeedboost()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 6.8f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 3.5f;
        }// simple speedboost mods for beginners, if you have any questions on how to start coding my dms are open
    }
}
