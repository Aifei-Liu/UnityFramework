﻿//----------------------------------------------
//            liuaf UnityFramework
// Copyright © 2015-2025 liuaf Entertainment
// Created by : Liu Aifei (329737941@qq.com)
//----------------------------------------------

using UnityEngine;
using System.Collections;

/// <summary>
/// @Summary : The object processing is not destroyed when the scene is switched
/// @Auther : liuaifei
/// @Date : 2014.04.22
/// </summary>
/// 
public class DontDestroyMe : MonoBehaviour 
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
