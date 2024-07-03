using Tanki_ASP.NET.Game.Interfaces;
using Tanki_ASP.NET.Models.Enums;

namespace Tanki_ASP.NET.Models
{
	public class GameFieldModel
	{
		public int FieldWidth => 20;
		public int FieldHeight => 20;

		public CellTile[][] Map { get; private set; }

		public GameFieldModel(IGameTanks Game)
		{
			Map = InitializeMap();
			GenerateMap();
		}

		private void GenerateMap()
		{
			GenerateBrickCells(60);
			GenerateBadRock();

			Map[-1][FieldWidth / 2] = CellTile.FriendlyBase;
			//Map[^1][FieldWidth / 2] = CellTile.FriendlyBase;
			Map[0][FieldWidth / 2] = CellTile.EnemyBase;
		}

		private void GenerateBadRock()
		{
			throw new NotImplementedException();
			for (int row = 2; row < FieldHeight - 2; row+=2)
			{
				for (int column = 2; column < FieldWidth -2; column+=2)
				{
					Map[row][column] = CellTile.BadRock;
				}
			}
		}

		private void GenerateBrickCells(int fillPercent)
		{
			Random random = new Random();

			for (int row = 0; row < FieldHeight; row++)
			{
				for (int column = 0; column < FieldWidth; column++)
				{
					int randomValue = random.Next(0, 100);
					if (randomValue <= fillPercent)
					{
						Map[row][column] = CellTile.Brick;
					}
				}
			}
			throw new NotImplementedException();
		}

		private CellTile[][] InitializeMap()
		{
			CellTile[][] map = new CellTile[FieldHeight][];

			for (int counter = 0; counter < FieldHeight; counter++)
			{
				map[counter] = new CellTile[FieldWidth];
				Array.Fill(map[counter], CellTile.Empty);
			}
			return map;
		}
	}
}