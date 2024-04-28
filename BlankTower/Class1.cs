using System.Linq;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Extensions;
using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;

using Il2CppAssets.Scripts.Unity;

using BTD_Mod_Helper.Api.Display;

using Il2CppAssets.Scripts.Unity.Display;



namespace Template
{


    public class Template : BloonsTD6Mod


    {
       
       
        class Template000 : ModDisplay
        {
            public override string BaseDisplay => Game.instance.model.GetTower("DartMonkey").display.guidRef;


            public override void ModifyDisplayNode(UnityDisplayNode node)
            {

             

            }

        }
       
   

        public class TemplateTower : ModTower
            {

                public override TowerSet TowerSet => TowerSet.Primary;
                public override string BaseTower => "DartMonkey";
                public override int Cost => 100;
                public override bool DontAddToShop => false;
                public override string DisplayName => "Template Monkey";

         //   public override ParagonMode ParagonMode => ParagonMode.Base000;
            public override int TopPathUpgrades => 5;
                public override int MiddlePathUpgrades => 5;
                public override int BottomPathUpgrades => 5;
        
            public override string Description => "Does nothing";


                public override void ModifyBaseTowerModel(TowerModel towerModel)
                {

              
             
            }

                public override int GetTowerIndex(System.Collections.Generic.List<TowerDetailsModel> towerSet)
                {
           
                    return towerSet.First(model => model.towerId == TowerType.BombShooter).towerIndex + 1;
                }


            }
      

        public class Upgrade100 : ModUpgrade<TemplateTower>
            {
                public override int Path => TOP;
                public override int Tier => 1;
                public override string DisplayName => "Blank100";
                public override int Cost => 100;

      
            public override string Description => "";


                public override void ApplyUpgrade(TowerModel tower)
                {
               
            }

            }

            public class Upgrade200 : ModUpgrade<TemplateTower>
            {
                public override int Path => TOP;
                public override int Tier => 2;
                public override string DisplayName => "Blank200";

                public override int Cost => 100;

                public override string Description => "";

                public override void ApplyUpgrade(TowerModel tower)
                {
           
            }


            }


            public class Upgrade300 : ModUpgrade<TemplateTower>
            {
                public override int Path => TOP;
                public override int Tier => 3;
                public override string DisplayName => "Blank300";

                public override int Cost => 100;

                public override string Description => "";

                public override void ApplyUpgrade(TowerModel tower)
                {

               

                }


            }

            public class Upgrade400 : ModUpgrade<TemplateTower>
            {
                public override int Path => TOP;
                public override int Tier => 4;
                public override string DisplayName => "Blank400";

                public override int Cost => 100;

                public override string Description => "";

                public override void ApplyUpgrade(TowerModel tower)
                {
              
            }


            }
            public class Upgrade500 : ModUpgrade<TemplateTower>
            {
                public override int Path => TOP;
                public override int Tier => 5;
                public override string DisplayName => "Blank500";

                public override int Cost => 100;

                public override string Description => "";

                public override void ApplyUpgrade(TowerModel tower)
                {


                }
            }


            public class Upgrade010 : ModUpgrade<TemplateTower>
            {
                public override int Path => Middle;
                public override int Tier => 1;
                public override string DisplayName => "Blank010";
                public override int Cost => 100;

                public override string Description => "";


                public override void ApplyUpgrade(TowerModel tower)
                {

                  

                }

            }

            public class Upgrade020 : ModUpgrade<TemplateTower>
            {
                public override int Path => Middle;
                public override int Tier => 2;
                public override string DisplayName => "Blank020";

                public override int Cost => 100;

                public override string Description => "";

                public override void ApplyUpgrade(TowerModel tower)
                {
             
                }


            }
            public class Upgrade030 : ModUpgrade<TemplateTower>
            {
                public override int Path => Middle;
                public override int Tier => 3;
                public override string DisplayName => "Blank030";

                public override int Cost => 100;

                public override string Description => "";

                public override void ApplyUpgrade(TowerModel tower)
                {
                
                }


            }
            public class Upgrade040 : ModUpgrade<TemplateTower>
            {
                public override int Path => Middle;
                public override int Tier => 4;
                public override string DisplayName => "Blank040";

                public override int Cost => 100;

                public override string Description => "";

                public override void ApplyUpgrade(TowerModel tower)
                {
                 

                }


            }
            public class Upgrade050 : ModUpgrade<TemplateTower>
            {
                public override int Path => Middle;
                public override int Tier => 5;
                public override string DisplayName => "Blank050";

                public override int Cost => 100;

                public override string Description => "";

                public override void ApplyUpgrade(TowerModel tower)
                {
                  
                }


            }
            public class Upgrade001 : ModUpgrade<TemplateTower>
            {
                public override int Path => Bottom;
                public override int Tier => 1;
                public override string DisplayName => "Blank001";
                public override int Cost => 100;

                public override string Description => "";


                public override void ApplyUpgrade(TowerModel tower)
                {
                   
                 

                }

            }

            public class Upgrade002 : ModUpgrade<TemplateTower>
            {
                public override int Path => Bottom;
                public override int Tier => 2;
                public override string DisplayName => "Blank002";

                public override int Cost => 100;

                public override string Description => "";

                public override void ApplyUpgrade(TowerModel tower)
                {
                  
                }


            }
            public class Upgrade003 : ModUpgrade<TemplateTower>
            {
                public override int Path => Bottom;
                public override int Tier => 3;
                public override string DisplayName => "Blank003";

                public override int Cost => 100;

                public override string Description => "";

                public override void ApplyUpgrade(TowerModel tower)
                {
           

                }


            }
            public class Upgrade004 : ModUpgrade<TemplateTower>
            {
                public override int Path => Bottom;
                public override int Tier => 4;
                public override string DisplayName => "Blank004";

                public override int Cost => 100;

                public override string Description => "";

                public override void ApplyUpgrade(TowerModel tower)
                {
            
                }


            }
            public class Upgrade005 : ModUpgrade<TemplateTower>
            {
                public override int Path => Bottom;
                public override int Tier => 5;
                public override string DisplayName => "Blank005";

                public override int Cost => 100;

                public override string Description => "";

                public override void ApplyUpgrade(TowerModel tower)
                {
                
                }


            }
        }

           



        

        
     

    
}
