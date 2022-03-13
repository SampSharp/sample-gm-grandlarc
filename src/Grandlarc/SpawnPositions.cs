﻿using System.Collections.Generic;
using SampSharp.GameMode;

namespace Grandlarc
{
    public class SpawnPositions
    {
        public static IDictionary<City, IList<WorldPosition>> Positions =
            new Dictionary<City, IList<WorldPosition>>
            {
                [City.LasVenturas] = new WorldPosition[]
                {
                    new(new Vector3(1435.8024f, 2662.3647f, 11.3926f), 1.1650f),
                    new(new Vector3(1457.4762f, 2773.4868f, 10.8203f), 272.2754f),
                    new(new Vector3(1739.6390f, 2803.0569f, 14.2735f), 285.3929f),
                    new(new Vector3(1870.3096f, 2785.2471f, 14.2734f), 42.3102f),
                    new(new Vector3(1959.7142f, 2754.6863f, 10.8203f), 181.4731f),
                    new(new Vector3(2314.2556f, 2759.4504f, 10.8203f), 93.2711f),
                    new(new Vector3(2216.5674f, 2715.0334f, 10.8130f), 267.6540f),
                    new(new Vector3(2101.4192f, 2678.7874f, 10.8130f), 92.0607f),
                    new(new Vector3(1951.1090f, 2660.3877f, 10.8203f), 180.8461f),
                    new(new Vector3(1666.6949f, 2604.9861f, 10.8203f), 179.8495f),
                    new(new Vector3(2808.3367f, 2421.5107f, 11.0625f), 136.2060f),
                    new(new Vector3(2633.3203f, 2349.7061f, 10.6719f), 178.7175f),
                    new(new Vector3(2606.6348f, 2161.7490f, 10.8203f), 88.7508f),
                    new(new Vector3(2616.5286f, 2100.6226f, 10.8158f), 177.7834f),
                    new(new Vector3(2491.8816f, 2397.9370f, 10.8203f), 266.6003f),
                    new(new Vector3(2531.7891f, 2530.3223f, 21.8750f), 91.6686f),
                    new(new Vector3(2340.6677f, 2530.4324f, 10.8203f), 177.8630f),
                    new(new Vector3(2097.6855f, 2491.3313f, 14.8390f), 181.8117f),
                    new(new Vector3(1893.1000f, 2423.2412f, 11.1782f), 269.4385f),
                    new(new Vector3(1698.9330f, 2241.8320f, 10.8203f), 357.8584f),
                    new(new Vector3(1479.4559f, 2249.0769f, 11.0234f), 306.3790f),
                    new(new Vector3(1298.1548f, 2083.4016f, 10.8127f), 256.7034f),
                    new(new Vector3(1117.8785f, 2304.1514f, 10.8203f), 81.5490f),
                    new(new Vector3(1108.9878f, 1705.8639f, 10.8203f), 0.6785f),
                    new(new Vector3(1423.9780f, 1034.4188f, 10.8203f), 90.9590f),
                    new(new Vector3(1537.4377f, 752.0641f, 11.0234f), 271.6893f),
                    new(new Vector3(1917.9590f, 702.6984f, 11.1328f), 359.2682f),
                    new(new Vector3(2089.4785f, 658.0414f, 11.2707f), 357.3572f),
                    new(new Vector3(2489.8286f, 928.3251f, 10.8280f), 67.2245f),
                    new(new Vector3(2697.4717f, 856.4916f, 9.8360f), 267.0983f),
                    new(new Vector3(2845.6104f, 1288.1444f, 11.3906f), 3.6506f),
                    new(new Vector3(2437.9370f, 1293.1442f, 10.8203f), 86.3830f),
                    new(new Vector3(2299.5430f, 1451.4177f, 10.8203f), 269.1287f),
                    new(new Vector3(2214.3008f, 2041.9165f, 10.8203f), 268.7626f),
                    new(new Vector3(2005.9174f, 2152.0835f, 10.8203f), 270.1372f),
                    new(new Vector3(2222.1042f, 1837.4220f, 10.8203f), 88.6461f),
                    new(new Vector3(2025.6753f, 1916.4363f, 12.3382f), 272.5852f),
                    new(new Vector3(2087.9902f, 1516.5336f, 10.8203f), 48.9300f),
                    new(new Vector3(2172.1624f, 1398.7496f, 11.0625f), 91.3783f),
                    new(new Vector3(2139.1841f, 987.7975f, 10.8203f), 0.2315f),
                    new(new Vector3(1860.9672f, 1030.2910f, 10.8203f), 271.6988f),
                    new(new Vector3(1673.2345f, 1316.1067f, 10.8203f), 177.7294f),
                    new(new Vector3(1412.6187f, 2000.0596f, 14.7396f), 271.3568f)
                },
                [City.LosSantos] = new WorldPosition[]
                {
                    new(new Vector3(1751.1097f, -2106.4529f, 13.5469f), 183.1979f),
                    new(new Vector3(2652.6418f, -1989.9175f, 13.9988f), 182.7107f),
                    new(new Vector3(2489.5225f, -1957.9258f, 13.5881f), 2.3440f),
                    new(new Vector3(2689.5203f, -1695.9354f, 10.0517f), 39.5312f),
                    new(new Vector3(2770.5393f, -1628.3069f, 12.1775f), 4.9637f),
                    new(new Vector3(2807.9282f, -1176.8883f, 25.3805f), 173.6018f),
                    new(new Vector3(2552.5417f, -958.0850f, 82.6345f), 280.2542f),
                    new(new Vector3(2232.1309f, -1159.5679f, 25.8906f), 103.2939f),
                    new(new Vector3(2388.1003f, -1279.8933f, 25.1291f), 94.3321f),
                    new(new Vector3(2481.1885f, -1536.7186f, 24.1467f), 273.4944f),
                    new(new Vector3(2495.0720f, -1687.5278f, 13.5150f), 359.6696f),
                    new(new Vector3(2306.8252f, -1675.4340f, 13.9221f), 2.6271f),
                    new(new Vector3(2191.8403f, -1455.8251f, 25.5391f), 267.9925f),
                    new(new Vector3(1830.1359f, -1092.1849f, 23.8656f), 94.0113f),
                    new(new Vector3(2015.3630f, -1717.2535f, 13.5547f), 93.3655f),
                    new(new Vector3(1654.7091f, -1656.8516f, 22.5156f), 177.9729f),
                    new(new Vector3(1219.0851f, -1812.8058f, 16.5938f), 190.0045f),
                    new(new Vector3(1508.6849f, -1059.0846f, 25.0625f), 1.8058f),
                    new(new Vector3(1421.0819f, -885.3383f, 50.6531f), 3.6516f),
                    new(new Vector3(1133.8237f, -1272.1558f, 13.5469f), 192.4113f),
                    new(new Vector3(1235.2196f, -1608.6111f, 13.5469f), 181.2655f),
                    new(new Vector3(590.4648f, -1252.2269f, 18.2116f), 25.0473f),
                    new(new Vector3(842.5260f, -1007.7679f, 28.4185f), 213.9953f),
                    new(new Vector3(911.9332f, -1232.6490f, 16.9766f), 5.2999f),
                    new(new Vector3(477.6021f, -1496.6207f, 20.4345f), 266.9252f),
                    new(new Vector3(255.4621f, -1366.3256f, 53.1094f), 312.0852f),
                    new(new Vector3(281.5446f, -1261.4562f, 73.9319f), 305.0017f),
                    new(new Vector3(790.1918f, -839.8533f, 60.6328f), 191.9514f),
                    new(new Vector3(1299.1859f, -801.4249f, 84.1406f), 269.5274f),
                    new(new Vector3(1240.3170f, -2036.6886f, 59.9575f), 276.4659f),
                    new(new Vector3(2215.5181f, -2627.8174f, 13.5469f), 273.7786f),
                    new(new Vector3(2509.4346f, -2637.6543f, 13.6453f), 358.3565f)
                },
                [City.SanFierro] = new WorldPosition[]
                {
                    new(new Vector3(-2723.4639f, -314.8138f, 7.1839f), 43.5562f),
                    new(new Vector3(-2694.5344f, 64.5550f, 4.3359f), 95.0190f),
                    new(new Vector3(-2458.2000f, 134.5419f, 35.1719f), 303.9446f),
                    new(new Vector3(-2796.6589f, 219.5733f, 7.1875f), 88.8288f),
                    new(new Vector3(-2706.5261f, 397.7129f, 4.3672f), 179.8611f),
                    new(new Vector3(-2866.7683f, 691.9363f, 23.4989f), 286.3060f),
                    new(new Vector3(-2764.9543f, 785.6434f, 52.7813f), 357.6817f),
                    new(new Vector3(-2660.9402f, 883.2115f, 79.7738f), 357.4440f),
                    new(new Vector3(-2861.0796f, 1047.7109f, 33.6068f), 188.2750f),
                    new(new Vector3(-2629.2009f, 1383.1367f, 7.1833f), 179.7006f),
                    new(new Vector3(-2079.6802f, 1430.0189f, 7.1016f), 177.6486f),
                    new(new Vector3(-1660.2294f, 1382.6698f, 9.8047f), 136.2952f),
                    new(new Vector3(-1674.1964f, 430.3246f, 7.1797f), 226.1357f),
                    new(new Vector3(-1954.9982f, 141.8080f, 27.1747f), 277.7342f),
                    new(new Vector3(-1956.1447f, 287.1091f, 35.4688f), 90.4465f),
                    new(new Vector3(-1888.1117f, 615.7245f, 35.1719f), 128.4498f),
                    new(new Vector3(-1922.5566f, 886.8939f, 35.3359f), 272.1293f),
                    new(new Vector3(-1983.3458f, 1117.0645f, 53.1243f), 271.2390f),
                    new(new Vector3(-2417.6458f, 970.1491f, 45.2969f), 269.3676f),
                    new(new Vector3(-2108.0171f, 902.8030f, 76.5792f), 5.7139f),
                    new(new Vector3(-2097.5664f, 658.0771f, 52.3672f), 270.4487f),
                    new(new Vector3(-2263.6650f, 393.7423f, 34.7708f), 136.4152f),
                    new(new Vector3(-2287.5027f, 149.1875f, 35.3125f), 266.3989f),
                    new(new Vector3(-2039.3571f, -97.7205f, 35.1641f), 7.4744f),
                    new(new Vector3(-1867.5022f, -141.9203f, 11.8984f), 22.4499f),
                    new(new Vector3(-1537.8992f, 116.0441f, 17.3226f), 120.8537f),
                    new(new Vector3(-1708.4763f, 7.0187f, 3.5489f), 319.3260f),
                    new(new Vector3(-1427.0858f, -288.9430f, 14.1484f), 137.0812f),
                    new(new Vector3(-2173.0654f, -392.7444f, 35.3359f), 237.0159f),
                    new(new Vector3(-2320.5286f, -180.3870f, 35.3135f), 179.6980f),
                    new(new Vector3(-2930.0049f, 487.2518f, 4.9141f), 3.8258f)
                }
            };
    }
}