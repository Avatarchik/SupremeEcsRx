﻿using System.Threading.Tasks;
using EcsRx.Components;
using EcsRx.Entities;
using UniRx;
using UnityEngine;

namespace EcsRx.Framework.Components
{
    public class AsyncComponent : IComponent
    {
        public ReactiveProperty<GameObject> AsyncView;
        public async Task<Object> GetView()
        {
           return await AsyncView;
        }
    }
}