using UnityEditor;

public class CreateAssetsBundle
{
[MenuItem("Assets/Build AssetBundles")]
    static void BuildAssetBundle()
    {   
        BuildPipeline.BuildAssetBundles("Assets/AssetBundle", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
}
