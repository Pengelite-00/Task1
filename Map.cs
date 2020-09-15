using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinGame
{
    
        //Question 3.1 and 3.2
        public class Map
        {
            public Tile[,] gameMap;
            private Hero hero;
            private Enemy[] Enemies;
            private int mapWidth;                                                 //Declaration of variables
            private int mapHeight;
            private Random rnd;

            public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numEnemies)
            {
                mapWidth = rnd.Next(minWidth, maxWidth + 1);
                mapHeight = rnd.Next(minHeight, maxHeight + 1);                         //setting width and height to random values


               gameMap = new Tile[mapWidth, mapHeight];                               //Making 2D array same size as randomized dimensions

               Enemies = new Enemy[numEnemies];                                     //Creation of Enemies, not working after I changed my Create() method


               hero = (Hero)Create(Tile.TileType.Hero);                          //hero Creation, was working until I messed up my Create() method and removed it, not it doesn't function
               gameMap[hero.X, hero.Y] = hero;
               for (int i = 0; i < Enemies.Length; i++)
                {
                 Enemies[i] = (Enemy)Create(Tile.TileType.Enemy);
                 gameMap[Enemies[i].X, Enemies[i].Y] = Enemies[i];
                }


            }



        public int MapWidth                                     //Gets and Sets
        {
            get { return mapWidth; }
            private set { mapWidth = value; }
        }

        public int MapHeight
        {
            get { return mapHeight; }
            private set { mapHeight = value; }
        }

        public Tile[,] MapTiles
        {
            get { return mapTiles; }
            set { mapTiles = value; }
        }

        public Hero Hero
        {
            get { return hero; }
            set { hero = value; }
        }

        public Enemy[] Enemies
        {
            get { return enemies; }
            set { enemies = value; }
        }

        
        




        public void GenerateBorders()                                              //I believe this would work but didn't get the chance to test it, border generation
        {
            
            for (int i = 0; i < mapWidth; i++)
            {
                gameMap[i, 0] = new Obstacle(i, 0);
            }

            
            for (int j = 0; j < mapWidth; j++)
            {
                gameMap[j, mapHeight - 1] = new Obstacle(j, mapHeight);
            }

            
            for (int z = 0; z < mapHeight; z++)
            {
                gameMap[0, z] = new Obstacle(0, z);
            }

            
            for (int n = 0; n < mapHeight; n++)
            {
                gameMap[mapWidth - 1, n] = new Obstacle(mapWidth, n);
            }
        }

        




        
    }
}
