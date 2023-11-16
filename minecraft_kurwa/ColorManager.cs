﻿//
// minecraft_kurwa
// ZlomenyMesic, KryKom
//

using Microsoft.Xna.Framework;

namespace minecraft_kurwa {
    internal static class ColorManager {
        internal static readonly Vector3 FRONT_SHADOW = new(0.9f, 0.9f, 0.9f);
        internal static readonly Vector3 SIDE_SHADOW = new(0.8f, 0.8f, 0.8f);
        internal static readonly Vector3 BACK_SHADOW = new(0.7f, 0.7f, 0.7f);
        internal static readonly Vector3 BOTTOM_SHADOW = new(0.6f, 0.6f, 0.6f);
        internal static readonly Vector3 TOP_SHADOW = new(1.0f, 1.0f, 1.0f);

        internal static readonly Color[] LIST = {
            new(19, 109, 21),
            new(19, 133, 16),
            new(65, 152, 10),
            new(120, 144, 48),
            new(144, 120, 48),
            new(103, 146, 125),
            new(255, 255, 255)
        };
        internal static Colors GetTypeColor(VoxelType? voxelType, BiomeType biomeType, int altitude) {
            // TODO: colors based on biome type

            if (voxelType == VoxelType.GRASS) {
                if (altitude > 70) return Colors.SNOW;
                else if (altitude > 66) return new System.Random().Next(0, 2) == 0 ? Colors.SNOW : Colors.GRASS_COLD;
                else if (altitude < 10) return Colors.GRASS_NORMAL;
                return Colors.GRASS_COLD;
            } 
            else if (voxelType == VoxelType.STONE) {
                return Colors.ROCK;
            }

            return Colors.GRASS_COLD;
        }
    }

    internal enum Colors {
        GRASS_COLD = 0,
        GRASS_NORMAL = 1,
        GRASS_WARM = 2,
        GRASS_DRY = 3,
        DIRT_DRY = 4,
        ROCK = 5,
        SNOW = 6,
    }
}