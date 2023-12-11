﻿using System.IO;
using UnityEngine;
using UnityEditor.AssetImporters;

[ScriptedImporter(1, "lua")]
public class LuaScriptedImporter : ScriptedImporter {
	public override void OnImportAsset(AssetImportContext ctx) {
		TextAsset lua = new TextAsset(File.ReadAllText(ctx.assetPath));
		ctx.AddObjectToAsset("main", lua);
		ctx.SetMainObject(lua);
	}
}
