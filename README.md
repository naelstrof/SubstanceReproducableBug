This is for the bug reported for the Unity Substance Plugin here: https://forum.substance3d.com/index.php?topic=33846

Steps to reproduce: Build the game, try to run it. (Or download the pre-built in Releases)
If the texture stays at 32x32 resolution then it failed to regenerate.

Error log at `C:\Users\%UserName%\AppData\LocalLow\DefaultCompany\SubstanceReproducableBug\Player.log` should contain the error:

```
C++ Texture packing error for mask!
UnityEngine.DebugLogHandler:Internal_Log(LogType, LogOption, String, Object)
UnityEngine.DebugLogHandler:LogFormat(LogType, Object, String, Object[])
UnityEngine.Logger:Log(LogType, Object)
UnityEngine.Debug:Log(Object)
Substance.Game.Log:Message(String)
Substance.Game.NativeCallbacks:csharpLogCallback(Int32, String)
System.Object:wrapper_native_00007FFD15E45290(IntPtr, String, Int32[], String, Int32[], Int32)
Substance.Platform.NativeFunctions:cppModifyTexturePacking(IntPtr, String, Int32[], String, Int32[], Int32) (at C:\SubstanceReproducableBug\Assets\Allegorithmic\Plugins\Substance.Platform\NativeFunctions.cs:978)
Substance.Game.SubstanceGraph:UpdateTexturePacking(TexturePackingItem)
Substance.Game.SubstanceGraph:UpdateTexturePacking()
Substance.Game.SubstanceGraph:set_tpList(List`1)
Substance.Game.SubstanceGraph:OnSubstanceLoaded()
Substance.Game.Substance:LoadSubstanceInternal(String, Byte[], Object, UInt32[], String[], String[], Int32[], Int32[], Int32)
Substance.Game.Substance:OnEnable()
 
(Filename: C:/SubstanceReproducableBug/Assets/Allegorithmic/Plugins/Substance.Platform/NativeFunctions.cs Line: 978)
```


Works fine in the editor, just not in the build please fix!