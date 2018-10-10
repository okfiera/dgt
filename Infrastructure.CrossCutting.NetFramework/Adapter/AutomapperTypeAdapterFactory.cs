//===================================================================================
// Microsoft Developer & Platform Evangelism
//=================================================================================== 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
//===================================================================================
// Copyright (c) Microsoft Corporation.  All Rights Reserved.
// This code is released under the terms of the MS-LPL license, 
// http://microsoftnlayerapp.codeplex.com/license
//===================================================================================

using AutoMapper;
using Infrastructure.Crosscutting.Adapter;
using System;
using System.Diagnostics;
using System.Linq;

namespace Infrastructure.Crosscutting.NetFramework.Adapter
{
    public class AutomapperTypeAdapterFactory
        :ITypeAdapterFactory
    {
        #region Constructor

        /// <summary>
        /// Create a new Automapper type adapter factory
        /// </summary>
        public AutomapperTypeAdapterFactory()
        {
            try
            {
                //scan all assemblies finding Automapper Profile
                var profiles = AppDomain.CurrentDomain
                                        .GetAssemblies()
                                        .SelectMany(a => a.GetTypes())
                                        .Where(t => t.BaseType == typeof(Profile));

                var y = profiles.ToList();

                Mapper.Initialize(cfg =>
                {
                    foreach (var item in profiles)
                    {
                        try
                        {
                            if (item.FullName != "AutoMapper.SelfProfiler`2" &&
                                item.FullName != "AutoMapper.Configuration.MapperConfigurationExpression" &&
                                item.FullName != "AutoMapper.Configuration.MapperConfigurationExpression+NamedProfile")
                            {
                                cfg.AddProfiles(item);
                            }
                               
                        }
                        catch (Exception ex)
                        {
                            Debug.Print(ex.Message);
                        }
                    }
                });
            }
            catch (System.Reflection.ReflectionTypeLoadException typeEx)
            {
                var msg = "";
                foreach (var i in typeEx.LoaderExceptions)
                {
                    msg += i.Message + Environment.NewLine;
                }
                throw new Exception(msg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            
        }

        #endregion

        #region ITypeAdapterFactory Members

        public ITypeAdapter Create()
        {
            return new AutomapperTypeAdapter();
        }

        #endregion
    }
}
