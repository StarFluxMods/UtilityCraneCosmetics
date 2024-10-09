using CraneCosmetics.Customs.Types;
using CraneCosmetics.Enums;
using KitchenLib.Utils;
using UnityEngine;

namespace UtilityCraneCosmetics.Customs.Claws
{
    public class LocationPointerHeadless : CustomCraneCosmetic
    {
        public override string UniqueNameID => "PumpkinHat";
        public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("LocationPointerHeadless").AssignMaterialsByNames();
        public override CraneCosmeticType CosmeticType => CraneCosmeticType.Claw;
        public override bool HideOriginal => true;
    }
}