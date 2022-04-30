using OWML.Common;
using OWML.ModHelper;
using UnityEngine;

namespace BigHeads
{
    internal class Character
    {
        #region Static Members

        internal static IModHelper modHelper;

        #region TimberHearth

        #region LowerVillage

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

        #region UpperVillage

        public static Character Gossan = new()
        {
            name = "Gossan",
            objectName = "Villager_HEA_Gossan",
            headPath = new[] { 1, 2, 0, 2, 0, 0, 1, 0, }
        };

        public static Character Arkose = new()
        {
            name = "Arkose",
            objectName = "Villager_HEA_Arkose_GhostMatter",
            headPath = new[] { 2, 2, 0, 2, 0, 0, 1, 0, }
        };

        public static Character Moraine = new()
        {
            name = "Moraine",
            objectName = "Villager_HEA_Moraine",
            headPath = new[] { 0, 1, 0, 2, 0, 0, 1, 0, }
        };

        #endregion

        #region Observatory

        public static Character Hornfels = new()
        {
            name = "Hornfels",
            objectName = "Villager_HEA_Hornfels",
            headPath = new[] { 1, 2, 0, 2, 0, 0, 1, 0, }
        };

        public static Character Hal = new()
        {
            name = "Hal",
            objectName = "Character_HEA_Hal_Museum",
            headPath = new[] { 1, 2, 0, 2, 0, 0, 1, 0, }
        };

        public static Character Hornfels_Statue = new()
        {
            name = "Hornfels @ Statue",
            objectName = "Villager_HEA_Hornfels (1)",
            headPath = new[] { 1, 2, 0, 2, 0, 0, 1, 0, }
        };

        #endregion

        #region Other

        public static Character Hal_PostObservatory = new()
        {
            name = "Hal: Post Observatory",
            objectName = "Villager_HEA_Hal_Outside",
            headPath = new[] { 1, 2, 0, 2, 0, 0, 1, 0, }
        };

        public static Character Tephra_PostObservatory = new()
        {
            name = "Tephra: Post Observatory",
            objectName = "Villager_HEA_Tephra_PostObservatory",
            headPath = new[] { 1, 1, 0, 2, 0, 0, 1, 0, }
        };

        public static Character Slate = new()
        {
            name = "Slate",
            objectName = "Villager_HEA_Slate",
            headPath = new[] { 0, 2, 0, 2, 0, 0, 1, 0, }
        };

        public static Character Tuff = new()
        {
            name = "Tuff",
            objectName = "Villager_HEA_Tuff",
            headPath = new[] { 2, 2, 0, 2, 0, 0, 1, 0, }
        };

        public static Character Tektite = new()
        {
            name = "Tektite",
            objectName = "Villager_HEA_Tektite_2",
            headPath = new[] { 0, 1, 0, 2, 0, 0, 1, 0, }
        };

        #endregion

        #endregion

        #region Travellers

        public static Character Chert = new()
        {
            name = "Chert",
            objectName = "Traveller_HEA_Chert",
            headPath = new[] { 0, 2, 0, 2, 0, 0, 1, 0, }
        };

        public static Character Esker = new()
        {
            name = "Esker",
            objectName = "Villager_HEA_Esker",
            headPath = new[] { 0, 5, 0, 2, 0, 0, 1, 0, }
        };

        public static Character Riebeck = new()
        {
            name = "Riebeck",
            objectName = "Traveller_HEA_Riebeck",
            headPath = new[] { 0, 0, 0, 2, 2, 1, 0, 1, 0 }
        };

        public static Character Gabbro = new()
        {
            name = "Gabbro",
            objectName = "Traveller_HEA_Gabbro",
            headPath = new[] { 0, 3, 0, 2, 0, 0, 1, 0 }
        };

        public static Character Feldspar = new()
        {
            name = "Feldspar",
            objectName = "Traveller_HEA_Feldspar",
            headPath = new[] { 2, 2, 0, 2, 0, 0, 1, 0}
        };

        #endregion

        #region Nomai

        public static Character Solanum = new()
        {
            name = "Solanum",
            objectName = "Character_NOM_Solanum",
            headPath = new[] { 2, 2, 0, 6, 0, 0, 1, 0 }
        };

        #endregion

        #region DreamWorld

        #region ShroudedWoodlands

        public static Character Gilgamesh = new()
        {
            name = "Gilgamesh",
            objectName = "Prefab_IP_GhostBird_Gilgamesh",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        public static Character Enkidu = new()
        {
            name = "Enkidu",
            objectName = "Prefab_IP_GhostBird_Enkidu",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        public static Character EnkiTwo = new()
        {
            name = "EnkiTwo",
            objectName = "Prefab_IP_GhostBird_EnkiTwo",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        public static Character Pazuzu = new()
        {
            name = "Pazuzu",
            objectName = "Prefab_IP_GhostBird_Pazuzu",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        public static Character Bahomet = new()
        {
            name = "Bahomet",
            objectName = "Prefab_IP_GhostBird_Bahomet",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        public static Character Ebrietas = new()
        {
            name = "Ebrietas",
            objectName = "Prefab_IP_GhostBird_Ebrietas",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        public static Character Micolash = new()
        {
            name = "Micolash",
            objectName = "Prefab_IP_GhostBird_Micolash",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        public static Character Amygdala = new()
        {
            name = "Amygdala",
            objectName = "Prefab_IP_GhostBird_Amygdala",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        public static Character Gehrman = new()
        {
            name = "Gehrman",
            objectName = "Prefab_IP_GhostBird_Gehrman",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        #endregion

        #region StarlitCove

        public static Character FalseKnight = new()
        {
            name = "FalseKnight",
            objectName = "Prefab_IP_GhostBird_FalseKnight",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        public static Character Hornet = new()
        {
            name = "Hornet",
            objectName = "Prefab_IP_GhostBird_Hornet",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        public static Character Zote = new()
        {
            name = "Zote",
            objectName = "Prefab_IP_GhostBird_Zote",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        public static Character Nosk = new()
        {
            name = "Nosk",
            objectName = "Prefab_IP_GhostBird_Nosk",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        #endregion

        #region EndlessCanyon

        public static Character Yubaba = new()
        {
            name = "Yubaba",
            objectName = "Prefab_IP_GhostBird_Yubaba",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        public static Character Bou = new()
        {
            name = "Bou",
            objectName = "Prefab_IP_GhostBird_Bou",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        public static Character NoFace = new()
        {
            name = "NoFace",
            objectName = "Prefab_IP_GhostBird_NoFace",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        public static Character Kamaji = new()
        {
            name = "Kamaji",
            objectName = "Prefab_IP_GhostBird_Kamaji",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        #endregion

        public static Character Prisoner = new()
        {
            name = "Prisoner",
            objectName = "Prefab_IP_GhostBird_Prisoner",
            headPath = new[] { 0, 0, 0, 1, 0, 0, 3, 3, 0 }
        };

        #endregion

        public static Character[] All =
        {
            //------Timber Hearth------
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
            Gossan,
            Arkose,
            Moraine,
            Hornfels,
            Hal,
            Hornfels_Statue,
            Hal_PostObservatory,
            Tephra_PostObservatory,
            Slate,
            Tuff,
            Tektite,
            //-------Travellers------
            Chert,
            Esker,
            Riebeck,
            Gabbro,
            Feldspar,
            //------Nomai------
            Solanum,
            //------Owlelk------
            Gilgamesh,
            Enkidu,
            EnkiTwo,
            Pazuzu,
            Bahomet,
            Ebrietas,
            Micolash,
            Amygdala,
            Gehrman,
            FalseKnight,
            Hornet,
            Zote,
            Nosk,
            Yubaba,
            Bou,
            NoFace,
            Kamaji
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
