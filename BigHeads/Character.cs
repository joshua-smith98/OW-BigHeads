using OWML.Common;
using OWML.ModHelper;
using UnityEngine;

namespace BigHeads
{
    internal class Character
    {
        #region Static Members

        internal static IModHelper modHelper;

        public static Character Slate = new()
        {
            name = "Slate",
            objectName = "Villager_HEA_Slate",
            headPath = new[] { 0, 2, 0, 2, 0, 0, 1, 0, }
        };

        #region TimberHearth_LowerVillage

        public static Character Mica = new()
        {
            name = "Mica",
            objectName = "Villager_HEA_Mica",
            headPath = new[] { 1, 1, 0, 2, 0, 0, 1, 0, }
        };

        public static Character Gneiss = new()
        {
            name = "Gneiss",
            objectName = "Villager_HEA_Gneiss",
            headPath = new[] { 0, 4, 0, 2, 0, 0, 2, 0, }
        };

        public static Character Spinel = new()
        {
            name = "Spinel",
            objectName = "Villager_HEA_Spinel",
            headPath = new[] { 0, 5, 0, 2, 0, 0, 1, 0, }
        };

        public static Character Rutile = new()
        {
            name = "Rutile",
            objectName = "Villager_HEA_Rutile",
            headPath = new[] { 0, 4, 0, 2, 0, 0, 1, 0, }
        };

        public static Character Marl = new()
        {
            name = "Marl",
            objectName = "Villager_HEA_Marl",
            headPath = new[] { 1, 2, 0, 3, 0, 0, 1, 0, }
        };

        public static Character Porphy = new()
        {
            name = "Porphy",
            objectName = "Villager_HEA_Porphy",
            headPath = new[] { 2, 2, 0, 2, 0, 0, 1, 0, }
        };

        public static Character Tephra = new()
        {
            name = "Tephra",
            objectName = "Villager_HEA_Tephra",
            headPath = new[] { 0, 1, 0, 2, 0, 0, 1, 0, }
        };

        public static Character Galena = new()
        {
            name = "Galena",
            objectName = "Villager_HEA_Galena",
            headPath = new[] { 0, 1, 0, 2, 0, 0, 1, 0, }
        };

        public static Character Tephra_Hidden = new()
        {
            name = "Tephra: Hide & Seek",
            objectName = "Villager_HEA_Tephra (1)",
            headPath = new[] { 0, 1, 0, 2, 0, 0, 1, 0, }
        };

        public static Character Galena_Hidden = new()
        {
            name = "Galena: Hide & Seek",
            objectName = "Villager_HEA_Galena (1)",
            headPath = new[] { 0, 1, 0, 2, 0, 0, 1, 0, }
        };

        #endregion

        #region TimberHearth_UpperVillage



        #endregion

        public static Character[] All =
        {
            Slate,
            Mica,
            Gneiss,
            Spinel,
            Rutile,
            Marl,
            Porphy,
            Tephra,
            Galena,
            Tephra_Hidden,
            Galena_Hidden,
        };

        #endregion

        public string name;
        public string objectName;
        public int[] headPath;

        public Transform GetTransform()
        {
            GameObject origin = GameObject.Find(objectName);
            if (origin is null)
            {
                modHelper.Console.WriteLine($"Could not find object '{objectName}'", MessageType.Error);
                return null;
            }

            Transform ret = origin.transform;
            string current;
            for (int i = 0; i < headPath.Length; i++)
            {
                current = ret.name;
                try
                {
                    ret = ret.GetChild(headPath[i]);
                }
                catch(UnityException)
                {
                    modHelper.Console.WriteLine($"Could not navigate to index '{headPath[i]}' from bone: '{current}'!", MessageType.Error);
                    return null;
                }
            }
            return ret;
        }
    }
}
