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
            m_tiles = new Tile[64] {
                new Tile { North = m_a, East = m_a, South = m_a, West = m_a },
                new Tile { North = m_b, East = m_a, South = m_a, West = m_a },
                new Tile { North = m_b, East = m_b, South = m_a, West = m_a },
                new Tile { North = m_b, East = m_b, South = m_b, West = m_a },
                new Tile { North = m_b, East = m_b, South = m_b, West = m_b },
                new Tile { North = m_c, East = m_a, South = m_a, West = m_a },
                new Tile { North = m_c, East = m_a, South = m_a, West = m_b },
                new Tile { North = m_c, East = m_a, South = m_b, West = m_a },
                new Tile { North = m_c, East = m_a, South = m_b, West = m_b },
                new Tile { North = m_c, East = m_b, South = m_a, West = m_a },
                new Tile { North = m_c, East = m_b, South = m_a, West = m_b },
                new Tile { North = m_c, East = m_b, South = m_b, West = m_a },
                new Tile { North = m_c, East = m_b, South = m_b, West = m_b },
                new Tile { North = m_c, East = m_b, South = m_c, West = m_a },
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile(),
                new Tile()
            };
        }
    }
}