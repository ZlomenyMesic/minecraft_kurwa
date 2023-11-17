﻿//
// minecraft_kurwa
// ZlomenyMesic, KryKom
//

namespace minecraft_kurwa {
    internal static class Biome {
        internal const int TROPICAL_DRY_BIOME_COUNT = 6;
        internal const int TROPICAL_RAINY_BIOME_COUNT = 3;
        internal const int SUBTROPICAL_BIOME_COUNT = 5;
        internal const int TEMPERATE_OCEANIC_BIOME_COUNT = 4;
        internal const int TEMPERATE_INLAND_BIOME_COUNT = 4;
        internal const int COLD_BIOME_COUNT = 4;

        internal static BiomeType GetBiome(int x, int z) {
            return x >= 0 && z >= 0 && x < Global.WORLD_SIZE && z < Global.WORLD_SIZE 
                ? (BiomeType)(Global.BIOME_MAP[x, z] - (Global.BIOME_MAP[x, z] % 10))
                : BiomeType.VOID;
        }

        internal static BiomeType GetSubbiome(int x, int z) {
            return x >= 0 && z >= 0 && x < Global.WORLD_SIZE && z < Global.WORLD_SIZE
                ? (BiomeType)Global.BIOME_MAP[x, z]
                : BiomeType.VOID;
        }

        internal static VoxelType GetTopBlock(BiomeType biome) {
            if (biome == BiomeType.TROPICAL_DRY_DESERT_SANDY) return VoxelType.SAND;
            if (biome == BiomeType.TROPICAL_DRY_DESERT_STONY) return VoxelType.STONE;
            if (biome == BiomeType.TROPICAL_DRY_DESERT_GRAVEL) return VoxelType.GRAVEL;
            if (biome == BiomeType.TROPICAL_DRY_DESERT_TERRACOTTA) return VoxelType.TERRACOTTA;
            if ((int)biome >= 50) return VoxelType.SNOW;

            return VoxelType.GRASS;
        }
    }

    internal enum BiomeType {
        VOID = -1,

        TROPICAL_DRY = 0,
        TROPICAL_DRY_DESERT_SANDY = 1,
        TROPICAL_DRY_DESERT_STONY = 2,
        TROPICAL_DRY_DESERT_GRAVEL = 3,
        TROPICAL_DRY_DESERT_TERRACOTTA = 4,
        TROPICAL_DRY_SAVANNA = 5,
        TROPICAL_DRY_WASTELAND = 6,

        TROPICAL_RAINY = 10,
        TROPICAL_RAINY_JUNGLE = 11,
        TROPICAL_RAINY_BAMBOO_JUNGLE = 12,
        TROPICAL_RAINY_PLAINS = 13,

        SUBTROPICAL = 20,
        SUBTROPICAL_CONIFEROUS_FOREST = 21,
        SUBTROPICAL_BROADLEAF_FOREST = 22,
        SUBTROPICAL_SAVANNA = 23,
        SUBTROPICAL_BUSH = 24,
        SUBTROPICAL_WASTELAND = 25,

        TEMPERATE_OCEANIC = 30,
        TEMPERATE_OCEANIC_CONIFEROUS_FOREST = 31,
        TEMPERATE_OCEANIC_BROADLEAF_FOREST = 32,
        TEMPERATE_OCEANIC_PLAINS = 33,
        TEMPERATE_OCEANIC_THORNS = 34,

        TEMPERATE_INLAND = 40,
        TEMPERATE_INLAND_CONIFEROUS_FOREST = 41,
        TEMPERATE_INLAND_BROADLEAF_FOREST = 42,
        TEMPERATE_INLAND_PLAINS = 43,
        TEMPERATE_INLAND_MEADOW = 44,

        COLD = 50,
        COLD_TAIGA = 51,
        COLD_HIGHLAND = 52,
        COLD_TUNDRA = 53,
        COLD_ICEBERG = 54
    }
}
