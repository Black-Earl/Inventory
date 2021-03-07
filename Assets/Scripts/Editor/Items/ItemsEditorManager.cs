using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Items;
using Items.Armor;

/// <summary>
/// Editor Items Manager
/// </summary>
public class ItemsEditorManager : EditorWindow
{
    private const string ROOT_FOLDER_PATH = "Assets/Inventory/Items/";
    private const string ARMOR_FOLDER_NAME = "Armors/";
    private const string FOOD_FOLDER_NAME = "Foods/";
    private const string POTIONS_FOLDER_NAME = "Potions/";
    private const string WEAPON_FOLDER_NAME = "Weapons/";
    private const char SEPARATOR_FOLDER = '/';

    [MenuItem("Items/ItemManager")]
    static void Init()
    {
        ItemsEditorManager window = (ItemsEditorManager) GetWindow(typeof(ItemsEditorManager));
        CreateFolders(ROOT_FOLDER_PATH);
        window.Show();
    }

    private void OnGUI()
    {
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("ShowAll"))
        {
            string[]  guids = AssetDatabase.FindAssets("t:Item");
            for (int i = 0; i < guids.Length; i++)
            {
              Item tt = AssetDatabase.LoadAssetAtPath<Item>(AssetDatabase.GUIDToAssetPath(guids[i]));
              Debug.LogError(tt.IconPath);
            }
        }

        if (GUILayout.Button("Create Armor"))
        {
            // string path = ROOT_FOLDER_PATH + ARMOR_FOLDER_NAME;
            // if (!TryGetPath(path))
            // {
            //     CreateFolders(path);
            // }
            //
            // path += "NewArmor.asset";
            // Armor example = CreateInstance<Armor>();
            // AssetDatabase.CreateAsset(example, path);
            // Save();
            // EditorUtility.FocusProjectWindow();
            // Selection.activeObject = example;
        }

        if (GUILayout.Button("Create Food"))
        {
            // string path = ROOT_FOLDER_PATH + FOOD_FOLDER_NAME;
            // if (!TryGetPath(path))
            // {
            //     CreateFolders(path);
            // }
            //
            // path += "NewFood.asset";
            // Food example = CreateInstance<Food>();
            // AssetDatabase.CreateAsset(example, path);
            // Save();
            // EditorUtility.FocusProjectWindow();
            // Selection.activeObject = example;
        }
        GUILayout.BeginHorizontal();
    }

    private void Save()
    {
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    private bool TryGetPath(string pathFolder)
    {
        string str = pathFolder.Remove(pathFolder.Length - 1);
        return AssetDatabase.IsValidFolder(str);
    }

    /// <summary>
    /// Create folders
    /// </summary>
    private static void CreateFolders(string pathFolder)
    {
        string[] paths = pathFolder.Split(SEPARATOR_FOLDER);
        string path = paths[0];
        string newPath = paths[0];

        for (int i = 1; i < paths.Length; i++)
        {
            if (!AssetDatabase.IsValidFolder(newPath))
            {
                AssetDatabase.CreateFolder(path, paths[i - 1]);
            }

            path = newPath;
            newPath += SEPARATOR_FOLDER + paths[i];
        }
    }
}