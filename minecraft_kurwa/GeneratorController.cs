﻿//
// minecraft_kurwa
// ZlomenyMesic, KryKom
//

namespace minecraft_kurwa {
    internal class GeneratorController {
        internal static void GenerateWorld() {
            Global.HEIGHT_MAP = TerrainGenerator.GenerateHeightMap();
            Global.BIOME_MAP = BiomeGenerator.GenerateBiomeMap();

            for (int x = 0; x < Global.WORLD_SIZE; x++) {
                for (int y = 0; y < Global.WORLD_SIZE; y++) {
                    Global.VOXEL_MAP[x, y, Global.HEIGHT_MAP[x, y]] = VoxelType.GRASS;

                    if (x > 0 && Global.HEIGHT_MAP[x - 1, y] + 1 < Global.HEIGHT_MAP[x, y]) for (int z = 1 + Global.HEIGHT_MAP[x - 1, y]; z < Global.HEIGHT_MAP[x, y]; z++) Global.VOXEL_MAP[x, y, z] = VoxelType.STONE;
                    if (y > 0 && Global.HEIGHT_MAP[x, y - 1] + 1 < Global.HEIGHT_MAP[x, y]) for (int z = 1 + Global.HEIGHT_MAP[x, y - 1]; z < Global.HEIGHT_MAP[x, y]; z++) Global.VOXEL_MAP[x, y, z] = VoxelType.STONE;
                    if (x < Global.WORLD_SIZE - 1 && Global.HEIGHT_MAP[x + 1, y] + 1 < Global.HEIGHT_MAP[x, y]) for (int z = 1 + Global.HEIGHT_MAP[x + 1, y]; z < Global.HEIGHT_MAP[x, y]; z++) Global.VOXEL_MAP[x, y, z] = VoxelType.STONE;
                    if (y < Global.WORLD_SIZE - 1 && Global.HEIGHT_MAP[x, y + 1] + 1 < Global.HEIGHT_MAP[x, y]) for (int z = 1 + Global.HEIGHT_MAP[x, y + 1]; z < Global.HEIGHT_MAP[x, y]; z++) Global.VOXEL_MAP[x, y, z] = VoxelType.STONE;
                }
            }
        }
    }
}