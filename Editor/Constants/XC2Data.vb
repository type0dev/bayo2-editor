''' <summary>
''' Information required to read an bayo1 save file.
''' </summary>
Public Class XC2Data
    Public Shared PlayerInfoOffsets As New Dictionary(Of XC2DataType, HexDataInfo) From {
        {XC2DataType.Halos, New HexDataInfo With {.Offset = &HA3B0, .Size = &H4, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Mandragora_Root, New HexDataInfo With {.Offset = &HA3E4, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Baked_Gecko, New HexDataInfo With {.Offset = &HA3DC, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Unicorn_Horn, New HexDataInfo With {.Offset = &HA3D4, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Yellow_Moon_Lollipop, New HexDataInfo With {.Offset = &HA3EC, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Mega_Bloody_Rose_Lollipop, New HexDataInfo With {.Offset = &HA3F4, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Bloody_Rose_Lollipop, New HexDataInfo With {.Offset = &HA3FC, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Mega_Purple_Magic_Lollipop, New HexDataInfo With {.Offset = &HA404, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Purple_Magic_Lollipop, New HexDataInfo With {.Offset = &HA40C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Mega_Green_Herb_Lollipop, New HexDataInfo With {.Offset = &HA414, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Green_Herb_Lollipop, New HexDataInfo With {.Offset = &HA41C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.item11, New HexDataInfo With {.Offset = &HA424, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.item12, New HexDataInfo With {.Offset = &HA42C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.Witchs_Recipes, New HexDataInfo With {.Offset = &HA434, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.item14, New HexDataInfo With {.Offset = &HA43C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.item15, New HexDataInfo With {.Offset = &HA444, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.item16, New HexDataInfo With {.Offset = &HA44C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.item17, New HexDataInfo With {.Offset = &HA454, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.item18, New HexDataInfo With {.Offset = &HA45C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.item19, New HexDataInfo With {.Offset = &HA464, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
        {XC2DataType.item20, New HexDataInfo With {.Offset = &HA46C, .Size = &H2, .ToSaveFileValue = FieldConversions.FromSimpleDecimal, .ToHumanReadableValue = FieldConversions.ToSimpleDecimal}}
        }



End Class
