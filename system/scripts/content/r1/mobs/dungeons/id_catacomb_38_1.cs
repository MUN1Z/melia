//--- Melia Script -----------------------------------------------------------
// Videntis Shrine Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'id_catacomb_38_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdCatacomb381MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("id_catacomb_38_1.Id1", MonsterId.Rootcrystal_01, 6, 7, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("id_catacomb_38_1.Id2", MonsterId.Socket_Bow, 23, 30, TendencyType.Aggressive);
		AddSpawner("id_catacomb_38_1.Id3", MonsterId.Socket_Mage, 23, 30, TendencyType.Aggressive);
		AddSpawner("id_catacomb_38_1.Id4", MonsterId.Velffigy_Green, 38, 50, TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 4 Spawn Points
		AddSpawnPoint("id_catacomb_38_1.Id1", "id_catacomb_38_1", Rectangle(1282, 18, 100));
		AddSpawnPoint("id_catacomb_38_1.Id1", "id_catacomb_38_1", Rectangle(-1027, -1510, 100));
		AddSpawnPoint("id_catacomb_38_1.Id1", "id_catacomb_38_1", Rectangle(419, -522, 100));
		AddSpawnPoint("id_catacomb_38_1.Id1", "id_catacomb_38_1", Rectangle(-547, 36, 100));
		AddSpawnPoint("id_catacomb_38_1.Id1", "id_catacomb_38_1", Rectangle(-1369, 1038, 100));
		AddSpawnPoint("id_catacomb_38_1.Id1", "id_catacomb_38_1", Rectangle(358, 1123, 100));
		AddSpawnPoint("id_catacomb_38_1.Id1", "id_catacomb_38_1", Rectangle(1397, 1438, 100));

		// 'Socket_Bow' GenType 16 Spawn Points
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-756, 267, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-313, 219, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-813, -5, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1413, 813, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1267, 1062, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(1568, 1137, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(333, -64, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(333, 147, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1350, 944, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(1211, -93, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(1316, -604, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(1617, -545, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(1630, -95, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(1117, -531, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(1408, -306, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(1525, 32, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-496, 338, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1132, 991, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1572, 855, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-447, 60, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(1278, 1141, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(1122, 979, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(94, -723, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(73, -657, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(187, -614, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(85, -549, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(400, -469, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(490, -515, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(513, -585, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(501, -698, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(500, -758, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(379, -787, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(315, -737, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(421, -722, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(250, -790, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(312, -813, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(164, -795, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(258, -703, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(336, -619, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(424, -538, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(451, -440, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(352, -516, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(280, -567, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(254, -639, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(195, -534, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(136, -654, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(140, -474, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(525, 60, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(527, 134, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(466, 146, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(463, 105, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(374, 105, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(401, 151, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(260, 77, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(197, -12, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(195, -110, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(295, -115, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(265, 12, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(338, -1, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(383, -91, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(454, -118, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(524, -99, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(418, 16, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(458, -53, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(386, 61, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(335, -130, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(205, 44, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-293, 8, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-385, -38, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-468, -47, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-755, -24, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-832, 72, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-873, 24, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-753, 49, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-900, 206, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-887, 376, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-777, 425, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-814, 363, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-594, 447, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-401, 424, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-334, 376, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-296, 328, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-282, 289, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-440, 387, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-552, 401, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-439, 138, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-355, 144, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-457, -613, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-430, -698, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-427, -795, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-466, -870, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-618, -893, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-701, -925, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-787, -868, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-795, -766, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-798, -691, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-689, -631, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-594, -625, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-540, -650, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-636, -724, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-628, -792, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-578, -776, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-583, -870, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-731, -820, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-721, -737, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-668, -677, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-503, -940, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-432, -924, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-416, -850, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-391, -727, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-479, -710, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-396, -623, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-804, -940, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-655, -946, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1039, -1422, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-935, -1465, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-871, -1541, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-923, -1626, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-913, -1686, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1103, -1687, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1114, -1515, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1259, -1687, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1320, -1482, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1293, -1364, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1173, -1296, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1323, -1317, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1059, -1279, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-938, -1292, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-842, -1303, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-850, -1386, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-898, -1469, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-915, -1572, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-863, -1655, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1048, -1470, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1002, -1505, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1109, -1593, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1060, -1624, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-841, -1720, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-972, -1644, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-978, -1547, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1108, -1417, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1232, -1369, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1152, -1609, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1297, -1624, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1181, -1708, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1328, -1545, 30));
		AddSpawnPoint("id_catacomb_38_1.Id2", "id_catacomb_38_1", Rectangle(-1331, -1412, 30));

		// 'Socket_Mage' GenType 17 Spawn Points
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(-1001, -1603, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(-1144, -1364, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(-1216, -1564, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(-931, -1416, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(-750, -655, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(-502, -676, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(-674, -863, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(185, -698, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(233, -460, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(442, -633, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(1214, -338, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(1711, -355, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(1444, -620, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(1446, -89, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(1453, -432, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(1214, -51, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(158, -590, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(-494, -816, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(258, -62, 30));
		AddSpawnPoint("id_catacomb_38_1.Id3", "id_catacomb_38_1", Rectangle(500, 4, 30));

		// 'Velffigy_Green' GenType 18 Spawn Points
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(136, 1173, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(369, 1032, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1306, 912, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1309, 1287, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1510, 1003, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1529, 1384, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1073, 1161, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-9, 922, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-647, 378, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-324, 77, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1466, 960, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1268, 816, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1493, 1092, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-648, 116, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-525, 177, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(579, -11, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(332, 68, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(111, -15, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1098, 1391, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(961, 1441, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-825, 267, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-531, -104, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-472, 423, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1377, 1229, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1458, 1402, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1520, 1252, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1501, 1172, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1573, 1199, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1425, 1214, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1561, 1099, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1430, 1003, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1457, 1101, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1417, 933, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1291, 1018, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1423, 1111, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1295, 1214, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1373, 1155, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1231, 1080, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1229, 983, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1135, 1077, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1166, 1184, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1215, 1143, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1117, 1222, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1408, 1437, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1398, 1358, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1317, 1388, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1254, 1470, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1265, 1357, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1124, 1313, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1173, 1414, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1200, 1281, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1069, 1268, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1051, 1401, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1620, 1390, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1612, 1314, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1444, 1298, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1390, 1285, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1366, 1093, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1627, 1061, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1625, 950, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1570, 902, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1484, 907, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1353, 861, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1219, 829, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1126, 824, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1035, 928, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(991, 1038, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1081, 1059, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1603, 7, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1673, -24, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1569, -68, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1611, -151, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1704, -214, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1671, -305, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1689, -414, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1750, -524, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1686, -653, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1621, -603, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1556, -439, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1504, -384, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1358, -430, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1366, -330, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1428, -380, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1557, -661, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1417, -578, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1488, -658, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1273, -637, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1132, -634, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1196, -550, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1234, -603, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1177, -507, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1273, -347, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1228, -444, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1218, -272, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1198, -328, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1332, -118, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1365, -204, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1450, -225, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1279, -75, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1255, -193, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1169, -247, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1510, -290, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(1578, -408, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(492, 937, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(335, 944, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(209, 941, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(209, 1118, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(309, 1167, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(424, 1139, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(460, 1099, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(487, 1030, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(342, 1112, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(432, 1222, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(488, 1178, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(354, 1226, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(264, 1214, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(265, 1052, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(290, 980, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(159, 1071, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(133, 987, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(62, 965, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-3, 988, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-47, 937, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1136, 800, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1214, 758, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1131, 901, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1227, 905, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1138, 1066, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1193, 1157, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1199, 1027, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1249, 978, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1292, 887, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1335, 773, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1464, 779, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1456, 870, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1565, 933, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1618, 893, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1597, 1050, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1608, 1139, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1428, 1126, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1516, 1014, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1384, 1037, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1256, 1146, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1139, 1134, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1217, 1108, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1343, 1082, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1390, 964, 30));
		AddSpawnPoint("id_catacomb_38_1.Id4", "id_catacomb_38_1", Rectangle(-1396, 876, 30));
	}
}
