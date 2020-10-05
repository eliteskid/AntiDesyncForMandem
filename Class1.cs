using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ExitGames.Client.Photon;
using Harmony;
using MelonLoader;

namespace AntiDesync
{
    public class AntiDesync : MelonMod
    {

        private static HarmonyInstance harmonyInstance;

        public override void OnApplicationStart()
        {

            harmonyInstance = HarmonyInstance.Create("AntiDesync");
            harmonyInstance.Patch(typeof(ObjectPublicAbstractSealedStPhStObInSeSiObBoStUnique).GetMethod("Method_Private_Static_Void_EventData_PDM_0", BindingFlags.Static | BindingFlags.Public), new HarmonyMethod(typeof(AntiDesync).GetMethod("AntiPrefix", BindingFlags.Static | BindingFlags.NonPublic)));

            MelonLogger.Log("Lol no more lag my guy Dm on discord if any issues : frog#4711");
        }


        private static bool AntiPrefix(ref EventData __0)
        {
            try
            {
                if (__0.Code == 209 || __0.Code == 210)
                    return false;
            }
            catch { }
            return true;

        }


      }
}