using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HellsGorge.Items.Weapons
{
    public class MagmusSword : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Magmus";
            item.damage = 17;
            item.melee = true;
            item.width = 52;
            item.height = 50;
            item.toolTip = "I Bite";
            item.useTime = 12;
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