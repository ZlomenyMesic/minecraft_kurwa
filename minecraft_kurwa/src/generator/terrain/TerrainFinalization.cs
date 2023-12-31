﻿//
// minecraft_kurwa
// ZlomenyMesic, KryKom
//

using minecraft_kurwa.src.global;
using minecraft_kurwa.src.renderer.voxels;

namespace minecraft_kurwa.src.generator.terrain;

internal static class TerrainFinalization {

    // fills gaps under blocks
    internal static void FillGaps() {
        for (ushort x = 0; x < Settings.WORLD_SIZE; x++) {
            for (ushort y = 0; y < Settings.WORLD_SIZE; y++) {
                if (x > 0 && Global.HEIGHT_MAP[x - 1, y] + 1 < Global.HEIGHT_MAP[x, y]) for (ushort z = (ushort)(1 + Global.HEIGHT_MAP[x - 1, y]); z < Global.HEIGHT_MAP[x, y]; z++) Global.VOXEL_MAP[x, y, z] = (byte)VoxelType.STONE;
                if (y > 0 && Global.HEIGHT_MAP[x, y - 1] + 1 < Global.HEIGHT_MAP[x, y]) for (ushort z = (ushort)(1 + Global.HEIGHT_MAP[x, y - 1]); z < Global.HEIGHT_MAP[x, y]; z++) Global.VOXEL_MAP[x, y, z] = (byte)VoxelType.STONE;
                if (x < Settings.WORLD_SIZE - 1 && Global.HEIGHT_MAP[x + 1, y] + 1 < Global.HEIGHT_MAP[x, y]) for (ushort z = (ushort)(1 + Global.HEIGHT_MAP[x + 1, y]); z < Global.HEIGHT_MAP[x, y]; z++) Global.VOXEL_MAP[x, y, z] = (byte)VoxelType.STONE;
                if (y < Settings.WORLD_SIZE - 1 && Global.HEIGHT_MAP[x, y + 1] + 1 < Global.HEIGHT_MAP[x, y]) for (ushort z = (ushort)(1 + Global.HEIGHT_MAP[x, y + 1]); z < Global.HEIGHT_MAP[x, y]; z++) Global.VOXEL_MAP[x, y, z] = (byte)VoxelType.STONE;
            }
        }
    }
}
