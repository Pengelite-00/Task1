using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinGame
{
    class GameEngine
    {
        private Map gameEngineMap;
        private static readonly char Hero = 'H';
        private static readonly char Empty = ' ';
        private static readonly char Goblin = 'G';                  //Declarations
        private static readonly char Obstacle = 'X';

        public GameEngine(int minWidth, int maxWidth, int minHeight, int maxHeight, int numOfEnemies)     //Constructor deriving variables from Map class
        {
            gameEngineMap = new Map(minWidth, maxWidth, minHeight, maxHeight, numOfEnemies);
        }

        public Map Map
        {
            get { return gameEngineMap; }
            set { gameEngineMap = value; }
        }

        public override string ToString()               //Method inteded to create 2D map, can't get mapHeight to register outside of the Map class unfortunately
        {
            string output = "";

            for (int i = 0; i < gameEngineMap.mapHeight; i++)
            {
                for (int j = 0; j < gameEngineMap.MapWidth; j++)
                {
                    switch (gameEngineMap.MapTiles[j, i].GetType().Name)
                    {
                        case nameof(Empty):
                            output += Empty;
                            break;
                        case nameof(Obstacle):
                            output += Obstacle;
                            break;
                        case nameof(Hero):
                            output += Hero;
                            break;
                        case nameof(Goblin):
                            output += Goblin;
                            break;
                    }
                    
                }
                output += "\n";                  //Output to go to next line
            }

            return output;            //End of Method
        }
    }
}
