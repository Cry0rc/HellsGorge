using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace HellsGorge.Items.Weapons
{
    public class ArlemiteSpear : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Arlemite Spear";
            item.damage = 38;
            item.melee = true;
            item.width = 44;
            item.height = 44;
            item.scale = 1.1f;
            item.maxStack = 1;
            item.useTime = 30;
            item.useAnimation = 30;
            item.knockBack = 4f;
            item.UseSound = SoundID.Item1;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.useTurn = true;
            item.useStyle = 5;
            item.value = 10000;
            item.rare = 3;
            item.shoot = mod.ProjectileType("ArlemiteSpearProj");
            item.shootSpeed = 5f;
        }
        public override void AddRecipes() 
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);  
            recipe.AddTile(TileID.WorkBenches);   
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
