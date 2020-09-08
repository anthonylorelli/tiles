using System;
using System.Drawing;

namespace experiment
{
    public class TileSet
    {
        private Tile[] m_tiles;
        private Color m_a = ColorPattern.PickRandom();
        private Color m_b = ColorPattern.PickRandom();
        private Color m_c = ColorPattern.PickRandom();
        private Color m_d = ColorPattern.PickRandom();

        public TileSet() {
            int id = -1;
            m_tiles = new Tile[64] {
                new Tile { North = m_d, East = m_c, South = m_b, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_a, East = m_a, South = m_a, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_b, East = m_a, South = m_a, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_b, East = m_b, South = m_a, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_b, East = m_b, South = m_b, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_b, East = m_b, South = m_b, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_c, East = m_a, South = m_a, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_c, East = m_a, South = m_a, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_c, East = m_a, South = m_b, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_c, East = m_a, South = m_b, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_c, East = m_b, South = m_a, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_c, East = m_b, South = m_a, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_c, East = m_b, South = m_b, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_c, East = m_b, South = m_b, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_c, East = m_b, South = m_c, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_c, East = m_c, South = m_a, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_c, East = m_c, South = m_a, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_c, East = m_c, South = m_b, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_c, East = m_c, South = m_b, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_c, East = m_c, South = m_c, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_c, East = m_c, South = m_c, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_c, East = m_c, South = m_c, West = m_c, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_a, South = m_a, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_a, South = m_a, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_a, South = m_a, West = m_c, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_a, South = m_b, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_a, South = m_b, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_a, South = m_b, West = m_c, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_a, South = m_c, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_a, South = m_c, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_a, South = m_c, West = m_c, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_b, South = m_a, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_b, South = m_a, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_b, South = m_a, West = m_c, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_b, South = m_b, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_b, South = m_b, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_b, South = m_b, West = m_c, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_b, South = m_c, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_b, South = m_c, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_b, South = m_c, West = m_c, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_b, South = m_d, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_c, South = m_a, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_c, South = m_a, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_c, South = m_a, West = m_c, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_c, South = m_b, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_c, South = m_b, West = m_c, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_c, South = m_c, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_c, South = m_c, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_c, South = m_c, West = m_c, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_c, South = m_d, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_c, South = m_d, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_d, South = m_a, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_d, South = m_a, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_d, South = m_a, West = m_c, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_d, South = m_b, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_d, South = m_b, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_d, South = m_b, West = m_c, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_d, South = m_c, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_d, South = m_c, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_d, South = m_c, West = m_c, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_d, South = m_d, West = m_a, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_d, South = m_d, West = m_b, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_d, South = m_d, West = m_c, Id = $"tile_{(++id).ToString()}" },
                new Tile { North = m_d, East = m_d, South = m_d, West = m_d, Id = $"tile_{(++id).ToString()}" }
            };
        }
    }
}