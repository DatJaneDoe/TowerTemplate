using System.Linq;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Extensions;
using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;

namespace Template
{

    public class Template : BloonsTD6Mod
    {

       


            public class TemplateTower : ModTower
            {

                public override TowerSet TowerSet => TowerSet.Primary;
                public override string BaseTower => "DartMonkey";
                public override int Cost => 100;
                public override bool DontAddToShop => false;
                public override string DisplayName => "Tower Template";
                public override int TopPathUpgrades => 5;
                public override int MiddlePathUpgrades => 0;
                public override int BottomPathUpgrades => 0;
                public override string Description => "A blank slate";


                public override void ModifyBaseTowerModel(TowerModel towerModel)
                {
              

                }

                public override int GetTowerIndex(System.Collections.Generic.List<TowerDetailsModel> towerSet)
                {
           
                    return towerSet.First(model => model.towerId == TowerType.BoomerangMonkey).towerIndex + 1;
                }


            }


            public class Upgrade100 : ModUpgrade<TemplateTower>
            {
                public override int Path => TOP;
                public override int Tier => 1;
                public override string DisplayName => "Untitled";
                public override int Cost => 200;

                public override string Description => "Blank description";


                public override void ApplyUpgrade(TowerModel tower)
                {

                }

            }

            public class Upgrade200 : ModUpgrade<TemplateTower>
            {
                public override int Path => TOP;
                public override int Tier => 2;
                public override string DisplayName => "Untitled";

                public override int Cost => 300;

                public override string Description => "Blank description";

                public override void ApplyUpgrade(TowerModel tower)
                {

                 
                }


            }


            public class Upgrade300 : ModUpgrade<TemplateTower>
            {
                public override int Path => TOP;
                public override int Tier => 3;
                public override string DisplayName => "Untitled";

                public override int Cost => 400;

                public override string Description => "Blank description";

                public override void ApplyUpgrade(TowerModel tower)
                {
                   
                }


            }

            public class Upgrade400 : ModUpgrade<TemplateTower>
            {
                public override int Path => TOP;
                public override int Tier => 4;
                public override string DisplayName => "Untitled";

                public override int Cost => 500;

                public override string Description => "Blank description";

                public override void ApplyUpgrade(TowerModel tower)
                {
                   

                }


            }
            public class Upgrade500 : ModUpgrade<TemplateTower>
            {
                public override int Path => TOP;
                public override int Tier => 5;
                public override string DisplayName => "Untitled";

                public override int Cost => 0;

                public override string Description => "Blank description";

                public override void ApplyUpgrade(TowerModel tower)
                {
                    

                }


            }

           



        

        
     

    }
}
