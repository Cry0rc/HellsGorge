using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellsGorge.Items.Weapons
{
    public class MagmaSword : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Magma Sword";
            item.damage = 17;
            item.melee = true;
            item.width = 54;
            item.height = 54;
            item.toolTip = "Burn";
            item.useTime = 10;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 54;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}