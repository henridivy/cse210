public class WorldTravelerBadge : Badge
{
    public override void CreateBadge()
    {
        // _design = new List<string>()
        // {
        //     "                0000000000              ",
        //     "            0000\        _0000            ",
        //     "          0000000|     __\000000          ",
        //     "        0000000/       \00/\00/\00        ",
        //     "        00__0/         ____   / 00        ",
        //     "      00\   \\       _/00000\_/00000      ",
        //     "      00\\___      /00000000000\_ 00      ",
        //     "      000000\__    \00000000000_| 00      ",
        //     "        0000000\       \000000/ 00      ",
        //     "        0000000|       /000000/ 00      ",
        //     "          0000/  ___   \0000/00      ",
        //     "           0000 /0000\   \0/0000      ",
        //     "               000000000000      ",
        // };
        
        _design = new List<string>()
        {
            "                                           ",
            "                0000000000              ",
            "            0000\\        _0000            ",
            "          00    _|     __\\    00          ",
            "        00    _/       \\__/\\__/\\00        ",
            "        00__ /         ____   / 00        ",
            "      00\\   \\\\       _/     \\_/__ 00      ",
            "      00\\\\___      /           \\_ 00      ",
            "      00    \\__    \\___        _| 00      ",
            "        00     \\       \\      / 00      ",
            "        00     |       /     _/ 00      ",
            "          00  /  ___   \\   _/00      ",
            "           0000 /   \\   \\_/0000      ",
            "               000000000000      ",
            "                                           "
        };
        // throw new NotImplementedException();
    }
}